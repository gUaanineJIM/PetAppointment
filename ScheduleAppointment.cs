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
    public partial class ScheduleAppointment : Form
    {
        public ScheduleAppointment()
        {
            InitializeComponent();
            LoadPets();
            LoadAppointments();
        }

        private void ScheduleAppointment_Load(object sender, EventArgs e)
        {
            
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
            
        }

        private void AddTreatments_Click(object sender, EventArgs e)
        {
           
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

        private void RecordBills_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //function for loading the pets table
        private void LoadPets()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query to join pets and owners tables
                    string query = @"
                SELECT 
                    pets.pet_id AS 'Pet ID', 
                    pets.name AS 'Pet Name', 
                    CONCAT(owners.first_name, ' ', owners.last_name) AS 'Owner Name'
                FROM 
                    pets
                LEFT JOIN 
                    owners
                ON 
                    pets.owner_id = owners.owner_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    petLists.DataSource = dt; // Bind the result to the DataGridView or ListBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void textReasonofVisit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textPetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void texStaffId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScheduleAppointmentlabel_Click(object sender, EventArgs e)
        {

        }

        private void idpet_Click(object sender, EventArgs e)
        {

        }

        private void VetId_Click(object sender, EventArgs e)
        {

        }

        private void StaffId_Click(object sender, EventArgs e)
        {

        }

        private void ReasonofVisit_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }


        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {

        }

        //staff data grid view
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void StaffListBTN_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT staff_id AS 'Staff ID', first_name AS 'First Name', last_name AS 'Last Name', phone AS 'Phone' FROM staff";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Create a dialog box
                    Form dialog = new Form
                    {
                        Text = "Staff List",
                        Size = new Size(600, 400),
                        StartPosition = FormStartPosition.CenterParent
                    };

                    DataGridView dataGridView = new DataGridView
                    {
                        DataSource = dt,
                        Dock = DockStyle.Fill,
                        ReadOnly = true,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };

                    dialog.Controls.Add(dataGridView);
                    dialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void VetListBTN_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT vet_id AS 'Vet ID', first_name AS 'First Name', last_name AS 'Last Name', specialization AS 'Specialization', phone AS 'Phone' FROM vet_doctor";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Create a dialog box
                    Form dialog = new Form
                    {
                        Text = "Vet Doctor List",
                        Size = new Size(600, 400),
                        StartPosition = FormStartPosition.CenterParent
                    };

                    DataGridView dataGridView = new DataGridView
                    {
                        DataSource = dt,
                        Dock = DockStyle.Fill,
                        ReadOnly = true,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };

                    dialog.Controls.Add(dataGridView);
                    dialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Assuming the TextBox for date is named 'textDate' and for time is named 'texTime'
            textDate.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Format the date
            texTime.Text = dateTimePicker1.Value.ToString("hh:mm");    // Format the time
        }


        private void textDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void texTime_TextChanged(object sender, EventArgs e)
        {

        }


        private void textReasonofVisit_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Validate the appointment date
                    DateTime selectedDate = DateTime.Parse(textDate.Text);
                    if (selectedDate.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("The appointment date cannot be in the past. Please select a valid date.",
                                        "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }

                    // Validate the appointment time
                    DateTime selectedTime = DateTime.Parse(texTime.Text); // Parse the time from the TextBox
                    TimeSpan startTime = new TimeSpan(8, 0, 0); // 8:00 AM
                    TimeSpan endTime = new TimeSpan(17, 30, 0); // 5:30 PM

                    if (selectedTime.TimeOfDay < startTime || selectedTime.TimeOfDay > endTime)
                    {
                        MessageBox.Show("The appointment time must be between 8:00 AM and 5:30 PM.",
                                        "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if the time is invalid
                    }

                    conn.Open();

                    // SQL query to insert a new appointment
                    string query = @"
                INSERT INTO appointments (appointment_date, appointment_time, reason, pet_id, vet_id, staff_id)
                VALUES (@appointment_date, @appointment_time, @reason, @pet_id, @vet_id, @staff_id)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@appointment_date", textDate.Text); // Date from textDate
                        cmd.Parameters.AddWithValue("@appointment_time", texTime.Text); // Time from texTime
                        cmd.Parameters.AddWithValue("@reason", textReasonofVisit.Text); // Reason of visit
                        cmd.Parameters.AddWithValue("@pet_id", textPetId.Text); // Pet ID
                        cmd.Parameters.AddWithValue("@vet_id", textVetId.Text); // Vet ID
                        cmd.Parameters.AddWithValue("@staff_id", texStaffId.Text); // Staff ID

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAppointments();

                        // Clear the textboxes
                        ClearTextFields();

                    }
                }
                catch (MySqlException ex)
                {
                    // Handle SQL exceptions, including those triggered by the `before_appointment_insert` trigger
                    if (ex.Number == 1644) // Custom error from the trigger
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to clear the textboxes
        private void ClearTextFields()
        {
            textDate.Clear();
            texTime.Clear();
            textReasonofVisit.Clear();
            textPetId.Clear();
            textVetId.Clear();
            texStaffId.Clear();
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Validate the appointment date
                    DateTime selectedDate = DateTime.Parse(textDate.Text); // Parse the date from the TextBox
                    if (selectedDate.Date < DateTime.Now.Date) // Compare only the date part
                    {
                        MessageBox.Show("Cannot modify past appointments.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if the date is invalid
                    }

                    conn.Open();

                    // SQL query to update the appointment
                    string query = @"
                UPDATE appointments
                SET appointment_date = @appointment_date,
                    appointment_time = @appointment_time,
                    reason = @reason,
                    pet_id = @pet_id,
                    vet_id = @vet_id,
                    staff_id = @staff_id
                WHERE appointment_id = @appointment_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        
                        cmd.Parameters.AddWithValue("@pet_id", textPetId.Text); // Pet ID
                        cmd.Parameters.AddWithValue("@appointment_date", textDate.Text); // Date from textDate
                        cmd.Parameters.AddWithValue("@appointment_time", texTime.Text); // Time from texTime
                        cmd.Parameters.AddWithValue("@reason", textReasonofVisit.Text); // Reason of visit
                        cmd.Parameters.AddWithValue("@vet_id", textVetId.Text); // Vet ID
                        cmd.Parameters.AddWithValue("@staff_id", texStaffId.Text); // Staff ID

                        // Retrieve the appointment_id from the Tag property
                        if (textDate.Tag != null)
                        {
                            cmd.Parameters.AddWithValue("@appointment_id", textDate.Tag);
                        }
                        else
                        {
                            MessageBox.Show("No appointment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the appointments table
                        LoadAppointments();

                        // Clear the textboxes
                        ClearTextFields();
                    }
                }
                catch (MySqlException ex)
                {
                    
                    if (ex.Number == 1644) 
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void appointmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid (not a header row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = appointmentList.Rows[e.RowIndex];

                textDate.Text = DateTime.Parse(selectedRow.Cells["appointment_date"].Value?.ToString() ?? string.Empty).ToString("yyyy-MM-dd");
                texTime.Text = selectedRow.Cells["appointment_time"].Value?.ToString() ?? string.Empty;
                textReasonofVisit.Text = selectedRow.Cells["reason"].Value?.ToString() ?? string.Empty;
                textPetId.Text = selectedRow.Cells["pet_id"].Value?.ToString() ?? string.Empty;
                textVetId.Text = selectedRow.Cells["vet_id"].Value?.ToString() ?? string.Empty;
                texStaffId.Text = selectedRow.Cells["staff_id"].Value?.ToString() ?? string.Empty;

                textDate.Tag = selectedRow.Cells["appointment_id"].Value;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textDate.Tag == null || !int.TryParse(textDate.Tag.ToString(), out int appointmentId))
            {
                MessageBox.Show("Please select an appointment to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?",
                                                          "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlCommand disableFKChecks = new MySqlCommand("SET FOREIGN_KEY_CHECKS = 0;", conn))
                        {
                            disableFKChecks.ExecuteNonQuery();
                        }

                        string query = "DELETE FROM appointments WHERE appointment_id = @appointment_id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@appointment_id", appointmentId);

                            // Execute the query
                            cmd.ExecuteNonQuery();
                        }

                        // Re-enable foreign key checks
                        using (MySqlCommand enableFKChecks = new MySqlCommand("SET FOREIGN_KEY_CHECKS = 1;", conn))
                        {
                            enableFKChecks.ExecuteNonQuery();
                        }

                        MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the appointments table
                        LoadAppointments();

                        // Clear the textboxes
                        ClearTextFields();
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle SQL exceptions, including those triggered by the `before_appointment_delete` trigger
                    if (ex.Number == 1644) // Custom error from the trigger
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //function for loading the appointment table
        // Function for loading only upcoming appointments
        private void LoadAppointments()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query to select only upcoming appointments
                    string query = @"
                SELECT * 
                FROM appointments
                WHERE appointment_date >= CURDATE()
                ORDER BY appointment_date ASC, appointment_time ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    appointmentList.DataSource = dt; // Bind the result to the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void historyBTN_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch past appointments grouped by pet_id
                    string query = @"
                SELECT 
                    pet_id AS 'Pet ID',
                    GROUP_CONCAT(CONCAT(appointment_date, ' - ', reason, ' (', appointment_time, ')') SEPARATOR '\n') AS 'Appointments'
                FROM appointments
                WHERE appointment_date < CURDATE()
                GROUP BY pet_id
                ORDER BY pet_id ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Create a dialog box
                    Form dialog = new Form
                    {
                        Text = "Past Appointments",
                        Size = new Size(800, 600),
                        StartPosition = FormStartPosition.CenterParent
                    };

                    // Create a DataGridView to display the data
                    DataGridView dataGridView = new DataGridView
                    {
                        DataSource = dt,
                        Dock = DockStyle.Fill,
                        ReadOnly = true,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };

                    // Add the DataGridView to the dialog
                    dialog.Controls.Add(dataGridView);

                    // Show the dialog
                    dialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void treatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
