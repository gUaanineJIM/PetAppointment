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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            LoadStaff();
            stafftsList.CellClick += stafftsList_CellClick;


        }

        private void AddTreatments_Click(object sender, EventArgs e)
        {
           Treatments treatments = new Treatments();
            treatments.Show();
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
            Vet vet = new Vet();
            vet.Show();
            this.Close();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {

        }

        private void RecordBills_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Close();
        }

        private void schedAppointment_Click(object sender, EventArgs e)
        {
            ScheduleAppointment ScheduleAppointment = new ScheduleAppointment();
            ScheduleAppointment.Show();
            this.Close();
        }

        private void appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //function for loading staff
        private void LoadStaff()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM staff";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    stafftsList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textstaffFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textstaffLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (stafftsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected staff_id
            DataGridViewRow selectedRow = stafftsList.SelectedRows[0];
            int staffId = Convert.ToInt32(selectedRow.Cells["staff_id"].Value);

            // Get updated values from textboxes
            string updatedFirstName = textstaffFname.Text.Trim();
            string updatedLastName = textstaffLname.Text.Trim();
            string updatedPhone = textphone.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(updatedFirstName) || string.IsNullOrEmpty(updatedLastName) || string.IsNullOrEmpty(updatedPhone))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            // Check for duplicates (excluding the current staff member)
            if (IsDuplicateStaff(updatedFirstName, updatedLastName, updatedPhone, staffId))
            {
                MessageBox.Show("A staff member with the same first name, last name, and phone number already exists.");
                return;
            }

            // Update the staff member in the database
            UpdateStaff(staffId, updatedFirstName, updatedLastName, updatedPhone);

            // Reload the staff list
            LoadStaff();

            // Clear the textboxes
            ClearTextBoxes();
        }

        // Function to update a staff member in the database
        private void UpdateStaff(int staffId, string firstName, string lastName, string phone)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE staff SET first_name = @firstName, last_name = @lastName, phone = @phone WHERE staff_id = @staffId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffId", staffId);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff member updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void stafftsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid (not a header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = stafftsList.Rows[e.RowIndex];

                // Populate the textboxes with the selected row's data
                textstaffFname.Text = selectedRow.Cells["first_name"].Value?.ToString() ?? string.Empty;
                textstaffLname.Text = selectedRow.Cells["last_name"].Value?.ToString() ?? string.Empty;
                textphone.Text = selectedRow.Cells["phone"].Value?.ToString() ?? string.Empty;
            }
        }




        private void New_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        // Function to clear all textboxes
        private void ClearTextBoxes()
        {
            textstaffFname.Clear();
            textstaffLname.Clear();
            textphone.Clear();
        }




        private void Delete_Click(object sender, EventArgs e)
        {
            if (stafftsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected staff_id
            DataGridViewRow selectedRow = stafftsList.SelectedRows[0];
            int staffId = Convert.ToInt32(selectedRow.Cells["staff_id"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the staff member from the database
                DeleteStaff(staffId);

                // Reload the staff list
                LoadStaff();

                // Clear the textboxes
                ClearTextBoxes();
            }
        }

        // Function to delete a staff member from the database
        private void DeleteStaff(int staffId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM staff WHERE staff_id = @staffId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffId", staffId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff member deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void Find_Click(object sender, EventArgs e)
        {
            // Get the staff ID from the search textbox
            if (int.TryParse(staffIdSearch.Text.Trim(), out int staffId))
            {
                FindStaffById(staffId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID.");
            }
        }

        // Function to find a staff member by ID
        private void FindStaffById(int staffId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM staff WHERE staff_id = @staffId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffId", staffId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textstaffFname.Text = reader["first_name"].ToString();
                            textstaffLname.Text = reader["last_name"].ToString();
                            textphone.Text = reader["phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Staff member with the specified ID does not exist.");
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



        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string firstName = textstaffFname.Text.Trim();
            string lastName = textstaffLname.Text.Trim();
            string phone = textphone.Text.Trim();

            // Simple validation
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check for duplicates
            if (IsDuplicateStaff(firstName, lastName, phone))
            {
                MessageBox.Show("A staff member with the same first name, last name, and phone number already exists.");
                return;
            }

            // Add the staff member to the database
            AddNewStaff(firstName, lastName, phone);

            // Clear the textboxes after adding
            ClearTextBoxes();

            // Reload the staff list
            LoadStaff();
        }

        // Function to add a new staff member to the database
        private void AddNewStaff(string firstName, string lastName, string phone)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO staff (first_name, last_name, phone) VALUES (@firstName, @lastName, @phone)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff member added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private bool IsDuplicateStaff(string firstName, string lastName, string phone, int? excludeStaffId = null)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM staff WHERE first_name = @firstName AND last_name = @lastName AND phone = @phone";

                    if (excludeStaffId.HasValue)
                    {
                        query += " AND staff_id != @excludeStaffId";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    if (excludeStaffId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@excludeStaffId", excludeStaffId.Value);
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

        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
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
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Close();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backup_Click(object sender, EventArgs e)
        {

        }
    }
}
