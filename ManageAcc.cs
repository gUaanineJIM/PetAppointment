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
    public partial class ManageAcc : Form
    {
        public ManageAcc()
        {
            InitializeComponent();
            LoadAccounts();

        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void UsersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UsersTable.Rows[e.RowIndex];

                textName.Text = row.Cells["name"].Value?.ToString();
                textUsername.Text = row.Cells["username"].Value?.ToString();
                textPassword.Text = row.Cells["password"].Value?.ToString();
                textConfirmPassword.Text = row.Cells["password"].Value?.ToString();
                textFavPet.Text = row.Cells["sec_question"].Value?.ToString();

                // Store ID for use during update
                textName.Tag = row.Cells["id"].Value?.ToString();
            }
        }



        private void LoadAccounts()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch all data from the accounts table
                    string query = "SELECT id, name, username, password, sec_question FROM accounts";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the data to the UsersTable DataGridView
                    UsersTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFavPet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Validate that the passwords match
            if (textPassword.Text != textConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.BackColor = Color.Red;
                textConfirmPassword.BackColor = Color.Red;
                return;
            }
            else
            {
                textPassword.BackColor = SystemColors.Window;
                textConfirmPassword.BackColor = SystemColors.Window;
            }

            // Get values from textboxes
            string name = textName.Text.Trim();
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();
            string secQuestion = textFavPet.Text.Trim();

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(secQuestion))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check for duplicate credentials
                    string checkQuery = "SELECT COUNT(*) FROM accounts WHERE name = @name OR username = @username";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@name", name);
                        checkCmd.Parameters.AddWithValue("@username", username);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("An account with the same name or username already exists. Please use different credentials.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert the new account into the database
                    string insertQuery = @"
                INSERT INTO accounts (name, username, password, sec_question)
                VALUES (@name, @username, @password, @sec_question)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password); // Consider hashing the password for security
                        insertCmd.Parameters.AddWithValue("@sec_question", secQuestion);

                        insertCmd.ExecuteNonQuery();
                    }

                    // Show success message
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the UsersTable
                    LoadAccounts();

                    // Clear the input fields
                    textName.Clear();
                    textUsername.Clear();
                    textPassword.Clear();
                    textConfirmPassword.Clear();
                    textFavPet.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            textName.Clear();
            textUsername.Clear();
            textPassword.Clear();
            textConfirmPassword.Clear();
            textFavPet.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (textName.Tag == null || !int.TryParse(textName.Tag.ToString(), out int accountId))
            {
                MessageBox.Show("Please select an account to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the passwords match
            if (textPassword.Text != textConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.BackColor = Color.Red;
                textConfirmPassword.BackColor = Color.Red;
                return;
            }
            else
            {
                textPassword.BackColor = SystemColors.Window;
                textConfirmPassword.BackColor = SystemColors.Window;
            }

            // Get values from textboxes
            string name = textName.Text.Trim();
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();
            string secQuestion = textFavPet.Text.Trim();

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(secQuestion))
            {
                MessageBox.Show("All fields except password are required. Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check for duplicate username (excluding the current account)
                    string checkQuery = "SELECT COUNT(*) FROM accounts WHERE (name = @name OR username = @username) AND id != @id";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@name", name);
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@id", accountId);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("An account with the same name or username already exists. Please use different credentials.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update the account in the database
                    string updateQuery = @"
                UPDATE accounts
                SET name = @name, username = @username, password = @password, sec_question = @sec_question
                WHERE id = @id";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@name", name);
                        updateCmd.Parameters.AddWithValue("@username", username);
                        updateCmd.Parameters.AddWithValue("@password", string.IsNullOrEmpty(password) ? DBNull.Value : (object)password); // Update password only if provided
                        updateCmd.Parameters.AddWithValue("@sec_question", secQuestion);
                        updateCmd.Parameters.AddWithValue("@id", accountId);

                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAccounts();

                    ClearTextFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected (based on Tag value)
            if (textName.Tag == null || !int.TryParse(textName.Tag.ToString(), out int accountId))
            {
                MessageBox.Show("Please select an account to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm delete
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM accounts WHERE id = @id";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", accountId);
                        deleteCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh table and clear fields
                    LoadAccounts();
                    ClearTextFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backupTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupData backupData = new BackupData();
            backupData.Show();
            this.Close();
        }


        private void textVETID_TextChanged(object sender, EventArgs e)
        {
            // Get the user ID from the textbox
            string userId = textVETID.Text.Trim();

            // Perform the search if the textbox is not empty
            if (!string.IsNullOrEmpty(userId))
            {
                SearchUserById(userId);
            }
            else
            {
                // Reload all accounts if the textbox is cleared
                LoadAccounts();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            // Get the user ID from the textbox
            string userId = textVETID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter a User ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform the search
            SearchUserById(userId);
        }

        // Helper method to search for a user by ID
        private void SearchUserById(string userId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch the user with the specified ID
                    string query = "SELECT id, name, username, password, sec_question FROM accounts WHERE id = @userId";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the filtered data to the UsersTable DataGridView
                    UsersTable.DataSource = dt;

                    // Check if no results were found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No user found with the specified ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
