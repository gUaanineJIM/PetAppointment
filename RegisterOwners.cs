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
    public partial class RegisterOwners : Form
    {
        public RegisterOwners()
        {
            InitializeComponent();
            LoadOwners();
            registerOwnerList.CellClick += registerOwnerList_CellClick;
        }

        private void RegisterOwners_Load(object sender, EventArgs e)
        {
     
        }

        private void textaddress_TextChanged(object sender, EventArgs e)
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

        private void RegisterPet_Click(object sender, EventArgs e)
        {
            RegisterPets registerPets = new RegisterPets();
            registerPets.Show();
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

        }

        private void AddTreatments_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Close();
        }

        private void VetDoctor_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
            this.Close();
        }

        private void ScheduleAppointmentlabel_Click(object sender, EventArgs e)
        {

        }

        private void textownerFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelfname_Click(object sender, EventArgs e)
        {

        }

        private void textownerLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void textphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddOwner_Click(object sender, EventArgs e)
        {

        }

        private void appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // funtion to load the owners
        private void LoadOwners()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM owners";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    registerOwnerList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ownerIdSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            // Get the owner ID from the search textbox
            if (int.TryParse(ownerIdSearch.Text.Trim(), out int ownerId))
            {
                // Search for the owner in the database
                FindOwnerById(ownerId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Owner ID.");
            }
        }

        // Function to find an owner by ID
        private void FindOwnerById(int ownerId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM owners WHERE owner_id = @ownerId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textownerFname.Text = reader["first_name"].ToString();
                            textownerLname.Text = reader["last_name"].ToString();
                            textphone.Text = reader["phone"].ToString();
                            textaddress.Text = reader["address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Owner with the specified ID does not exist.");
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
            string firstName = textownerFname.Text.Trim();
            string lastName = textownerLname.Text.Trim();
            string phone = textphone.Text.Trim();
            string address = textaddress.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (IsDuplicateOwner(firstName, lastName, phone))
            {
                MessageBox.Show("An owner with the same first name, last name, and phone number already exists. Please use different details.");
                return;
            }

            AddNewOwner(firstName, lastName, phone, address);

            // Clear the textboxes after adding
            textownerFname.Clear();
            textownerLname.Clear();
            textphone.Clear();
            textaddress.Clear();

            LoadOwners();
        }


        private void AddNewOwner(string firstName, string lastName, string phone, string address)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO owners (first_name, last_name, phone, address) VALUES (@firstName, @lastName, @phone, @address)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Owner added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //handle duplicate owners
        private bool IsDuplicateOwner(string firstName, string lastName, string phone)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM owners WHERE phone = @phone AND first_name = @firstName AND last_name = @lastName";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);

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
            if (registerOwnerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected owner_id
            DataGridViewRow selectedRow = registerOwnerList.SelectedRows[0];
            int ownerId = Convert.ToInt32(selectedRow.Cells["owner_id"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteOwner(ownerId);

                LoadOwners();

                ClearTextBoxes();
            }
        }

        // Function to delete an owner from the database
        private void DeleteOwner(int ownerId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM owners WHERE owner_id = @ownerId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Owner deleted successfully.");
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
            textownerFname.Clear();
            textownerLname.Clear();
            textphone.Clear();
            textaddress.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (registerOwnerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected owner_id
            DataGridViewRow selectedRow = registerOwnerList.SelectedRows[0];
            int ownerId = Convert.ToInt32(selectedRow.Cells["owner_id"].Value);

            // Get updated values from textboxes
            string updatedFirstName = textownerFname.Text.Trim();
            string updatedLastName = textownerLname.Text.Trim();
            string updatedPhone = textphone.Text.Trim();
            string updatedAddress = textaddress.Text.Trim();

            if (string.IsNullOrEmpty(updatedFirstName) || string.IsNullOrEmpty(updatedLastName) ||
                string.IsNullOrEmpty(updatedPhone) || string.IsNullOrEmpty(updatedAddress))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Update in the database
                UpdateOwner(ownerId, updatedFirstName, updatedLastName, updatedPhone, updatedAddress);

                // Reload the DataGridView
                LoadOwners();

                // Optionally clear fields after update
                ClearTextBoxes();
            }
        }

        // Function to update an owner in the database
        private void UpdateOwner(int ownerId, string firstName, string lastName, string phone, string address)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE owners SET first_name = @firstName, last_name = @lastName, phone = @phone, address = @address WHERE owner_id = @ownerId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Owner updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void registerOwnerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = registerOwnerList.Rows[e.RowIndex];

                textownerFname.Text = selectedRow.Cells["first_name"].Value?.ToString() ?? string.Empty;
                textownerLname.Text = selectedRow.Cells["last_name"].Value?.ToString() ?? string.Empty;
                textphone.Text = selectedRow.Cells["phone"].Value?.ToString() ?? string.Empty;
                textaddress.Text = selectedRow.Cells["address"].Value?.ToString() ?? string.Empty;
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void registerPetToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            RegisterPets registerPets = new RegisterPets();
            registerPets.Show();
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

        private void registerNewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
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

        private void recordBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Close();

        }
    }
}
