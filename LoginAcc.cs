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
    public partial class LoginAcc : Form
    {
        public LoginAcc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void createAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signInForm = new SignIn(); 
            signInForm.Show();               
            this.Close();
        }

        private void ForgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverAcc recover = new RecoverAcc();
            recover.Show();
            this.Close();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // hardcoded
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            //Validate
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hardcoded admin credentials
            if (username == "admin" && password == "admin")
            {
                // Redirect to the Admin form
                MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide();
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to check if the username exists
                    string query = "SELECT name, password FROM accounts WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                string storedPassword = reader["password"].ToString();

                                // Check if the entered password matches the stored password
                                if (password == storedPassword)
                                {
                                    // Login successful
                                    MessageBox.Show($"Welcome, {name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Redirect to the dashboard
                                    dashboard dashboardForm = new dashboard();
                                    dashboardForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // Incorrect password
                                    DialogResult result = MessageBox.Show(
                                        "Incorrect password. Did you forget your password?",
                                        "Login Failed",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning
                                    );

                                    if (result == DialogResult.Yes)
                                    {
                                        // Redirect to the RecoverAcc form
                                        RecoverAcc recoverForm = new RecoverAcc();
                                        recoverForm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                // Username does not exist
                                MessageBox.Show("The username does not exist. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


    }
}
