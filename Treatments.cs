using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetAppointment
{
    public partial class Treatments : Form
    {
        public Treatments()
        {
            InitializeComponent();
            LoadTreatment();
            LoadAppointments();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void VetDoctor_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
            this.Close();
        }

        private void RegisterOwner_Click(object sender, EventArgs e)
        {
            RegisterOwners registerOwners = new RegisterOwners();
            registerOwners.Show();
            this.Close();
        }

        private void RegisterPet_Click(object sender, EventArgs e)
        {
            RegisterPets registerPets = new RegisterPets();
            registerPets.Show();
            this.Close();
        }

        private void schedAppointment_Click(object sender, EventArgs e)
        {
            ScheduleAppointment ScheduleAppointment = new ScheduleAppointment();
            ScheduleAppointment.Show();
            this.Close();
        }

        private void RecordBills_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

        private void Treatments_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid (not a header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with the selected row's data
                textcost.Text = selectedRow.Cells["cost"].Value?.ToString() ?? string.Empty;
                texttreatment.Text = selectedRow.Cells["treatment_description"].Value?.ToString() ?? string.Empty;
                textmedication.Text = selectedRow.Cells["medication"].Value?.ToString() ?? string.Empty;
                textappointmentId.Text = selectedRow.Cells["appointment_id"].Value?.ToString() ?? string.Empty;

                // Store treatment_id in Tag for update/delete reference
                textcost.Tag = selectedRow.Cells["treatment_id"].Value;
            }
        }




        //function for loading treatment
        private void LoadTreatment()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM treatment";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //function to load the appointment lists
        private void LoadAppointments()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get appointments without a treatment record
                    string query = @"
                SELECT 
                    a.appointment_id AS AppointmentID,
                    a.pet_id AS PetID,
                    a.vet_id AS VetID,
                    a.appointment_date AS AppointmentDate,
                    a.appointment_time AS AppointmentTime,
                    a.reason AS Reason,
                    a.staff_id AS StaffID
                FROM appointments a
                LEFT JOIN treatment t ON a.appointment_id = t.appointment_id
                WHERE t.treatment_id IS NULL";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void textcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttreatment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textmedication_TextChanged(object sender, EventArgs e)
        {

        }

        private void textappointmentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void vetIdSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string costText = textcost.Text.Trim();
            string treatment_description = texttreatment.Text.Trim();
            string medication = textmedication.Text.Trim();
            string appointmentIdText = textappointmentId.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(costText) || string.IsNullOrEmpty(treatment_description) ||
                string.IsNullOrEmpty(medication) || string.IsNullOrEmpty(appointmentIdText))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!decimal.TryParse(costText, out decimal cost))
            {
                MessageBox.Show("Invalid cost. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(appointmentIdText, out int appointmentId))
            {
                MessageBox.Show("Invalid Appointment ID. Please enter a valid number.");
                return;
            }

            // Check for duplicate appointment_id
            if (IsDuplicateAppointmentId(appointmentId))
            {
                MessageBox.Show("A treatment already exists for this Appointment ID. Please use a different Appointment ID.");
                return;
            }

            // Insert the treatment into the database
            AddNewTreatment(cost, treatment_description, medication, appointmentId);

            // Clear the textboxes after adding
            ClearTreatmentFields();

            // Reload the treatment list
            LoadTreatment();
        }

        //for duplicate checking
        private bool IsDuplicateAppointmentId(int appointmentId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM treatment WHERE appointment_id = @appointmentId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isDuplicate = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return isDuplicate;
        }

        private void AddNewTreatment(decimal cost, string treatment_description, string medication, int appointmentId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO treatment (cost, treatment_description, medication, appointment_id) VALUES (@cost, @treatment, @medication, @appointmentId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    cmd.Parameters.AddWithValue("@treatment", treatment_description);
                    cmd.Parameters.AddWithValue("@medication", medication);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Treatment added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            ClearTreatmentFields();

        }

        private void ClearTreatmentFields()
        {
            textcost.Clear();
            texttreatment.Clear();
            textmedication.Clear();
            textappointmentId.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Get the treatment_id from the Tag property of textcost
            if (textcost.Tag == null || !int.TryParse(textcost.Tag.ToString(), out int treatmentId))
            {
                MessageBox.Show("Please select a treatment to update.");
                return;
            }

            // Get updated values from textboxes
            string costText = textcost.Text.Trim();
            string treatmentDescription = texttreatment.Text.Trim();
            string medication = textmedication.Text.Trim();
            string appointmentIdText = textappointmentId.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(costText) || string.IsNullOrEmpty(treatmentDescription) ||
                string.IsNullOrEmpty(medication) || string.IsNullOrEmpty(appointmentIdText))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!decimal.TryParse(costText, out decimal cost))
            {
                MessageBox.Show("Invalid cost. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(appointmentIdText, out int appointmentId))
            {
                MessageBox.Show("Invalid Appointment ID. Please enter a valid number.");
                return;
            }

            // Check for duplicate appointment_id (excluding the current treatment)
            if (IsDuplicateAppointmentId(appointmentId, treatmentId))
            {
                MessageBox.Show("A treatment already exists for this Appointment ID. Please use a different Appointment ID.");
                return;
            }

            // Update the treatment in the database
            UpdateTreatment(treatmentId, cost, treatmentDescription, medication, appointmentId);

            // Clear the textboxes after updating
            ClearTreatmentFields();

            // Reload the treatment list
            LoadTreatment();
        }

        private void UpdateTreatment(int treatmentId, decimal cost, string treatmentDescription, string medication, int appointmentId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE treatment SET cost = @cost, treatment_description = @treatmentDescription, medication = @medication, appointment_id = @appointmentId WHERE treatment_id = @treatmentId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@treatmentId", treatmentId);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    cmd.Parameters.AddWithValue("@treatmentDescription", treatmentDescription);
                    cmd.Parameters.AddWithValue("@medication", medication);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Treatment updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private bool IsDuplicateAppointmentId(int appointmentId, int? excludeTreatmentId = null)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM treatment WHERE appointment_id = @appointmentId";

                    if (excludeTreatmentId.HasValue)
                    {
                        query += " AND treatment_id != @excludeTreatmentId";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    if (excludeTreatmentId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@excludeTreatmentId", excludeTreatmentId.Value);
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isDuplicate = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return isDuplicate;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            // Get the treatment_id from the Tag property of textcost
            if (textcost.Tag == null || !int.TryParse(textcost.Tag.ToString(), out int treatmentId))
            {
                MessageBox.Show("Please select a treatment to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this treatment?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the treatment from the database
                DeleteTreatment(treatmentId);

                // Clear the textboxes after deletion
                ClearTreatmentFields();

                // Reload the treatment list
                LoadTreatment();
            }
        }

        private void DeleteTreatment(int treatmentId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM treatment WHERE treatment_id = @treatmentId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@treatmentId", treatmentId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Treatment deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            // Call the search function with the input from vetIdSearch
            SearchTreatmentById(vetIdSearch.Text.Trim());
        }


        private void SearchTreatmentById(string treatmentIdText)
        {
            // Validate input
            if (string.IsNullOrEmpty(treatmentIdText))
            {
                MessageBox.Show("Please enter a Treatment ID to search.");
                return;
            }

            if (!int.TryParse(treatmentIdText, out int treatmentId))
            {
                MessageBox.Show("Invalid Treatment ID. Please enter a valid number.");
                return;
            }

            // Search for the treatment in the database
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM treatment WHERE treatment_id = @treatmentId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@treatmentId", treatmentId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the textboxes with the retrieved data
                            textcost.Text = reader["cost"].ToString();
                            texttreatment.Text = reader["treatment_description"].ToString();
                            textmedication.Text = reader["medication"].ToString();
                            textappointmentId.Text = reader["appointment_id"].ToString();

                            // Store treatment_id in Tag for update/delete reference
                            textcost.Tag = treatmentId;

                        }
                        else
                        {
                            MessageBox.Show("No treatment found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void noTreatmentbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to find appointments without a treatment record
                    string query = @"
                SELECT 
                    a.appointment_id AS AppointmentID,
                    p.name AS PetName,
                    CONCAT(o.first_name, ' ', o.last_name) AS OwnerName,
                    a.appointment_date AS AppointmentDate,
                    a.appointment_time AS AppointmentTime
                FROM appointments a
                LEFT JOIN treatment t ON a.appointment_id = t.appointment_id
                INNER JOIN pets p ON a.pet_id = p.pet_id
                INNER JOIN owners o ON p.owner_id = o.owner_id
                WHERE t.treatment_id IS NULL";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Create a new form to display the results
                        Form resultsForm = new Form
                        {
                            Text = "Appointments Without Treatment",
                            Size = new Size(800, 600),
                            StartPosition = FormStartPosition.CenterScreen
                        };

                        DataGridView dataGridView = new DataGridView
                        {
                            DataSource = dt,
                            Dock = DockStyle.Fill,
                            ReadOnly = true,
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        };

                        resultsForm.Controls.Add(dataGridView);
                        resultsForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No appointments without treatment records were found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleAppointment scheduleAppointment = new ScheduleAppointment();
            scheduleAppointment.Show();
            this.Close();
        }

        private void registerPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterOwners registerOwners = new RegisterOwners();
            registerOwners.Show();
            this.Close();
        }

        private void registerPetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegisterPets registerPets = new RegisterPets();
            registerPets.Show();
            this.Close();
        }

        private void registerNewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
            this.Close();
        }

        private void recordBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Close();
        }

        private void createTreatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }
    }

}
