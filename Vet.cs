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
    public partial class Vet : Form
    {
        public Vet()
        {
            InitializeComponent();
            vetLists.CellClick += vetLists_CellClick;
            vetIdSearch.TextChanged += vetIdSearch_TextChanged;
            LoadVetDoctors();
        }

        private void schedAppointment_Click(object sender, EventArgs e)
        {
            ScheduleAppointment ScheduleAppointment = new ScheduleAppointment();
            ScheduleAppointment.Show();
            this.Close();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
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

        private void VetDoctor_Click(object sender, EventArgs e)
        {

        }

        private void AddTreatments_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
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

        private void Vet_Load(object sender, EventArgs e)
        {

        }

        private void vetLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //function for adding vet doctors
        private void LoadVetDoctors()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM vet_doctor";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    vetLists.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string firstName = textvetFname.Text.Trim();
            string lastName = textvetLname.Text.Trim();
            string specialization = textspecialization.Text.Trim();
            string phone = textphone.Text.Trim();

            // Simple validation (optional but recommended)
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(specialization) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check for duplicates
            if (IsDuplicateVetDoctor(firstName, lastName, phone))
            {
                MessageBox.Show("A vet doctor with the same first name, last name, and phone number already exists. Please use different details.");
                return;
            }

            // Call the stored procedure to add the doctor
            AddNewDoctor(firstName, lastName, specialization, phone);

            // Clear the textboxes after adding
            textvetFname.Clear();
            textvetLname.Clear();
            textspecialization.Clear();
            textphone.Clear();

            // Reload the vet doctors list
            LoadVetDoctors();
        }

        //procedure for adding vet doctors
        private void AddNewDoctor(string firstName, string lastName, string specialization, string phone)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("AddNewDoctor", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@doc_first_name", firstName);
                    cmd.Parameters.AddWithValue("@doc_last_name", lastName);
                    cmd.Parameters.AddWithValue("@doc_specialization", specialization);
                    cmd.Parameters.AddWithValue("@doc_phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool IsDuplicateVetDoctor(string firstName, string lastName, string phone)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM vet_doctor WHERE first_name = @firstName AND last_name = @lastName AND phone = @phone";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);

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



        //input fields
        private void textspecialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void textvetLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textvetFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (vetLists.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow selectedRow = vetLists.SelectedRows[0];
            int vetId = Convert.ToInt32(selectedRow.Cells["vet_id"].Value);

            string updatedFirstName = textvetFname.Text.Trim();
            string updatedLastName = textvetLname.Text.Trim();
            string updatedSpecialization = textspecialization.Text.Trim();
            string updatedPhone = textphone.Text.Trim();

            if (string.IsNullOrEmpty(updatedFirstName) || string.IsNullOrEmpty(updatedLastName) ||
                string.IsNullOrEmpty(updatedSpecialization) || string.IsNullOrEmpty(updatedPhone))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            // Confirm update
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateVetDoctor(vetId, updatedFirstName, updatedLastName, updatedSpecialization, updatedPhone);

                LoadVetDoctors();

                textvetFname.Clear();
                textvetLname.Clear();
                textspecialization.Clear();
                textphone.Clear();
            }
        }


        //cell click
        private void vetLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = vetLists.Rows[e.RowIndex];

                textvetFname.Text = selectedRow.Cells["first_name"].Value?.ToString() ?? string.Empty;
                textvetLname.Text = selectedRow.Cells["last_name"].Value?.ToString() ?? string.Empty;
                textspecialization.Text = selectedRow.Cells["specialization"].Value?.ToString() ?? string.Empty;
                textphone.Text = selectedRow.Cells["phone"].Value?.ToString() ?? string.Empty;
            }
        }


        //function for updating vet doctors
        private void UpdateVetDoctor(int vetId, string firstName, string lastName, string specialization, string phone)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE vet_doctor SET first_name = @firstName, last_name = @lastName, specialization = @specialization, phone = @phone WHERE vet_id = @vetId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@vetId", vetId);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@specialization", specialization);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (vetLists.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected vet_id
            DataGridViewRow selectedRow = vetLists.SelectedRows[0];
            int vetId = Convert.ToInt32(selectedRow.Cells["vet_id"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the record from the database
                DeleteVetDoctor(vetId);

                // Reload the DataGridView
                LoadVetDoctors();

                // Clear the textboxes
                ClearTextBoxes();
            }
        }

        // Function to delete a vet doctor from the database
        private void DeleteVetDoctor(int vetId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM vet_doctor WHERE vet_id = @vetId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@vetId", vetId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        // Function to clear all textboxes
        private void ClearTextBoxes()
        {
            textvetFname.Clear();
            textvetLname.Clear();
            textspecialization.Clear();
            textphone.Clear();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            // Get the vet ID from the search textbox
            if (int.TryParse(vetIdSearch.Text.Trim(), out int vetId))
            {
                // Search for the vet doctor in the database
                FindVetDoctorById(vetId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Vet ID.");
            }
        }

        // Function to find a vet doctor by ID
        private void FindVetDoctorById(int vetId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM vet_doctor WHERE vet_id = @vetId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@vetId", vetId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the textboxes with the vet doctor's information
                            textvetFname.Text = reader["first_name"].ToString();
                            textvetLname.Text = reader["last_name"].ToString();
                            textspecialization.Text = reader["specialization"].ToString();
                            textphone.Text = reader["phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Vet doctor with the specified ID does not exist.");
                            ClearTextBoxes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void vetIdSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure the vet ID is valid
            if (!int.TryParse(textVETID.Text.Trim(), out int vetId))
            {
                MessageBox.Show("Please enter a valid Vet ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch the vet's name and total earnings
                    string query = @"
                SELECT 
                    CONCAT(first_name, ' ', last_name) AS VetName,
                    CalcVetTotalEarnings(@vet_id) AS TotalEarnings
                FROM vet_doctor
                WHERE vet_id = @vet_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vet_id", vetId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string vetName = reader["VetName"]?.ToString() ?? "Unknown Vet";
                                double totalEarnings = reader["TotalEarnings"] != DBNull.Value
                                    ? Convert.ToDouble(reader["TotalEarnings"])
                                    : 0;

                                MessageBox.Show(
                                    $"Vet Name: {vetName}\nTotal Earnings: {totalEarnings:C}",
                                    "Vet Earnings",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                            else
                            {
                                MessageBox.Show("Vet ID not found. Please enter a valid Vet ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textVETID_TextChanged(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
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

        }

        private void recordBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Close();
        }

        private void createTreatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Close();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

        private void vetIdup_TextChanged(object sender, EventArgs e)
        {
            // Do nothing when the text changes
        }

        private void searchUp_Click(object sender, EventArgs e)
        {
            // Trigger the search when the button is clicked
            if (int.TryParse(vetIdup.Text.Trim(), out int vetId))
            {
                SearchAndDisplayVetAppointments(vetId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Vet ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Function to search and display vet appointments
        private void SearchAndDisplayVetAppointments(int vetId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("VetUpcomApp_withVetSpec", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vet_id_param", vetId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Display the results in a dialog box with a DataGridView
                        Form resultsForm = new Form
                        {
                            Text = "Upcoming Appointments",
                            Size = new Size(800, 400),
                            StartPosition = FormStartPosition.CenterScreen // Center the dialog box
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
                        MessageBox.Show("No upcoming appointments found for the specified Vet ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
