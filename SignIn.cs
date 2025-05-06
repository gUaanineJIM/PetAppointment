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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Hide();
        }

        private void createAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Hide();
        }

        private void textFavPet_TextChanged(object sender, EventArgs e)
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

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
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

                    // Show success message and redirect to LoginAcc form
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginAcc loginAcc = new LoginAcc();
                    loginAcc.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
