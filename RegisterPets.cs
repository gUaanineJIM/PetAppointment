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
    public partial class RegisterPets : Form
    {
        public RegisterPets()
        {
            InitializeComponent();
            LoadOwners();
            LoadPets();
            petsList.CellClick += petsList_CellContentClick;

        }

        private void schedAppointment_Click(object sender, EventArgs e)
        {
            ScheduleAppointment ScheduleAppointment = new ScheduleAppointment();
            ScheduleAppointment.Show();
            this.Close();
        }

        private void RegisterOwner_Click(object sender, EventArgs e)
        {
            RegisterOwners registerOwners = new RegisterOwners();
            registerOwners.Show();
            this.Close();
        }

        private void VetDoctor_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
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

        private void AddTreatments_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Close();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

        private void RecordBills_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Close();
        }

        private void RegisterPets_Load(object sender, EventArgs e)
        {

        }

        private void ownersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    ownersList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void petsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid (not a header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = petsList.Rows[e.RowIndex];

                // Populate the textboxes with the pet's information
                textpetName.Text = selectedRow.Cells["name"].Value?.ToString() ?? string.Empty;
                textpetAge.Text = selectedRow.Cells["age"].Value?.ToString() ?? string.Empty;
                textpetAnimalType.Text = selectedRow.Cells["animal_type"].Value?.ToString() ?? string.Empty;
                textpetDescription.Text = selectedRow.Cells["description"].Value?.ToString() ?? string.Empty;
                textpetOwnerId.Text = selectedRow.Cells["owner_id"].Value?.ToString() ?? string.Empty;

                // Store the pet_id for updating
                textpetName.Tag = selectedRow.Cells["pet_id"].Value?.ToString();
            }
        }
        private void LoadPets()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query to fetch pets sorted by owner_id
                    string query = "SELECT * FROM pets ORDER BY owner_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    petsList.DataSource = dt;
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

        private void Find_Click(object sender, EventArgs e)
        {
            // Get the pet ID from the search textbox
            if (int.TryParse(ownerIdSearch.Text.Trim(), out int petId))
            {
                // Search for the pet in the database
                FindPetById(petId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Pet ID.");
            }
        }

        // Function to find a pet by ID
        private void FindPetById(int petId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM pets WHERE pet_id = @petId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@petId", petId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the textboxes with the pet's information
                            textpetName.Text = reader["name"].ToString();
                            textpetAge.Text = reader["age"].ToString();
                            textpetAnimalType.Text = reader["animal_type"].ToString();
                            textpetDescription.Text = reader["description"].ToString();
                            textpetOwnerId.Text = reader["owner_id"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Pet with the specified ID does not exist.");
                            ClearPetTextBoxes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearPetTextBoxes()
        {
            textpetName.Clear();
            textpetAge.Clear();
            textpetAnimalType.Clear();
            textpetDescription.Clear();
            textpetOwnerId.Clear();
        }



        private void ownerIdSearch_TextChanged(object sender, EventArgs e)
        {
            // Automatically search when the user types a valid ID
            if (int.TryParse(ownerIdSearch.Text.Trim(), out int petId))
            {
                FindPetById(petId);
            }
            else if (string.IsNullOrEmpty(ownerIdSearch.Text.Trim()))
            {
                // Clear the textboxes if the search box is empty
                ClearPetTextBoxes();
            }
        }


        private void textpetDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void textpetOwnerId_TextChanged(object sender, EventArgs e)
        {

        }
        private void textpetAnimalType_TextChanged(object sender, EventArgs e)
        {

        }
        private void textpetAge_TextChanged(object sender, EventArgs e)
        {

        }
        private void textpetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string petName = textpetName.Text.Trim();
            string petAnimalType = textpetAnimalType.Text.Trim();
            string petDescription = textpetDescription.Text.Trim();
            string petAgeText = textpetAge.Text.Trim();
            string ownerIdText = textpetOwnerId.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(petName) || string.IsNullOrEmpty(petAnimalType) ||
                string.IsNullOrEmpty(petAgeText) || string.IsNullOrEmpty(ownerIdText))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!int.TryParse(petAgeText, out int petAge))
            {
                MessageBox.Show("Invalid Age. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(ownerIdText, out int ownerId))
            {
                MessageBox.Show("Invalid Owner ID. Please enter a valid number.");
                return;
            }

            // Check for duplicates
            if (IsDuplicatePet(petName, petAnimalType, petAge, ownerId))
            {
                MessageBox.Show("A pet with the same name, animal type, and age already exists for this owner.");
                return;
            }

            // Insert the pet into the database
            AddNewPet(petName, petAnimalType, petDescription, petAge, ownerId);

            // Clear the textboxes after adding
            ClearPetTextBoxes();

            // Reload the pets list
            LoadPets();
        }

        private void AddNewPet(string petName, string petAnimalType, string petDescription, int petAge, int ownerId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO pets (name, animal_type, description, age, owner_id) VALUES (@petName, @petAnimalType, @petDescription, @petAge, @ownerId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@petName", petName);
                    cmd.Parameters.AddWithValue("@petAnimalType", petAnimalType);
                    cmd.Parameters.AddWithValue("@petDescription", petDescription);
                    cmd.Parameters.AddWithValue("@petAge", petAge);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool IsDuplicatePet(string petName, string petAnimalType, int petAge, int ownerId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM pets WHERE name = @petName AND animal_type = @petAnimalType AND age = @petAge AND owner_id = @ownerId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@petName", petName);
                    cmd.Parameters.AddWithValue("@petAnimalType", petAnimalType);
                    cmd.Parameters.AddWithValue("@petAge", petAge);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);

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

        private void Update_Click(object sender, EventArgs e)
        {
            // Get the pet_id from the Tag property of textpetName
            if (textpetName.Tag == null || !int.TryParse(textpetName.Tag.ToString(), out int petId))
            {
                MessageBox.Show("Please select a pet to update.");
                return;
            }

            // Get updated values from textboxes
            string petName = textpetName.Text.Trim();
            string petAnimalType = textpetAnimalType.Text.Trim();
            string petDescription = textpetDescription.Text.Trim();
            string petAgeText = textpetAge.Text.Trim();
            string ownerIdText = textpetOwnerId.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(petName) || string.IsNullOrEmpty(petAnimalType) ||
                string.IsNullOrEmpty(petAgeText) || string.IsNullOrEmpty(ownerIdText))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!int.TryParse(petAgeText, out int petAge))
            {
                MessageBox.Show("Invalid Age. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(ownerIdText, out int ownerId))
            {
                MessageBox.Show("Invalid Owner ID. Please enter a valid number.");
                return;
            }

            // Check for duplicates
            if (IsDuplicatePet(petName, petAnimalType, petAge, ownerId, petId))
            {
                MessageBox.Show("A pet with the same name, animal type, and age already exists for this owner.");
                return;
            }

            // Update the pet in the database
            UpdatePet(petId, petName, petAnimalType, petDescription, petAge, ownerId);

            // Clear the textboxes after updating
            ClearPetTextBoxes();

            // Reload the pets list
            LoadPets();
        }


        private bool IsDuplicatePet(string petName, string petAnimalType, int petAge, int ownerId, int? excludePetId = null)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM pets WHERE name = @petName AND animal_type = @petAnimalType AND age = @petAge AND owner_id = @ownerId";

                    if (excludePetId.HasValue)
                    {
                        query += " AND pet_id != @excludePetId";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@petName", petName);
                    cmd.Parameters.AddWithValue("@petAnimalType", petAnimalType);
                    cmd.Parameters.AddWithValue("@petAge", petAge);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);

                    if (excludePetId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@excludePetId", excludePetId.Value);
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


        private void UpdatePet(int petId, string petName, string petAnimalType, string petDescription, int petAge, int ownerId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE pets SET name = @petName, animal_type = @petAnimalType, description = @petDescription, age = @petAge, owner_id = @ownerId WHERE pet_id = @petId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@petId", petId);
                    cmd.Parameters.AddWithValue("@petName", petName);
                    cmd.Parameters.AddWithValue("@petAnimalType", petAnimalType);
                    cmd.Parameters.AddWithValue("@petDescription", petDescription);
                    cmd.Parameters.AddWithValue("@petAge", petAge);
                    cmd.Parameters.AddWithValue("@ownerId", ownerId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Get the pet_id from the Tag property of textpetName
            if (textpetName.Tag == null || !int.TryParse(textpetName.Tag.ToString(), out int petId))
            {
                MessageBox.Show("Please select a pet to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this pet?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the pet from the database
                DeletePet(petId);

                // Clear the textboxes after deletion
                ClearPetTextBoxes();

                // Reload the pets list
                LoadPets();
            }
        }

        private void DeletePet(int petId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM pets WHERE pet_id = @petId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@petId", petId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void New_Click(object sender, EventArgs e)
        {
            ClearPetTextBoxes();

            textpetName.Tag = null;

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
