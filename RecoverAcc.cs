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
    public partial class RecoverAcc : Form
    {
        public RecoverAcc()
        {
            InitializeComponent();
        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Close();
        }

        private void textRecoveryPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Verify_Click(object sender, EventArgs e)
        {
            // Get the entered username and recovery pin
            string username = textUsername.Text.Trim();
            string recoveryPin = textRecoveryPin.Text.Trim();

            // Validate that both fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(recoveryPin))
            {
                MessageBox.Show("Please enter both username and recovery pin.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to check if the username exists and validate the recovery pin
                    string query = "SELECT name, sec_question FROM accounts WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                string storedRecoveryPin = reader["sec_question"].ToString();

                                // Check if the entered recovery pin matches the stored recovery pin
                                if (recoveryPin == storedRecoveryPin)
                                {
                                    // Recovery pin is correct, prompt for new password
                                    reader.Close(); // Close the reader before executing another query

                                    // Show dialog to enter new password
                                    using (Form passwordForm = new Form())
                                    {
                                        passwordForm.Text = "Reset Password";
                                        passwordForm.Size = new Size(300, 200);
                                        passwordForm.StartPosition = FormStartPosition.CenterParent;

                                        Label labelNewPassword = new Label { Text = "New Password:", Location = new Point(10, 20) };
                                        TextBox textNewPassword = new TextBox { Location = new Point(120, 20), Width = 150, PasswordChar = '*' };

                                        Label labelConfirmPassword = new Label { Text = "Confirm Password:", Location = new Point(10, 60) };
                                        TextBox textConfirmPassword = new TextBox { Location = new Point(120, 60), Width = 150, PasswordChar = '*' };

                                        Button btnSave = new Button { Text = "Save", Location = new Point(100, 100), DialogResult = DialogResult.OK };

                                        passwordForm.Controls.Add(labelNewPassword);
                                        passwordForm.Controls.Add(textNewPassword);
                                        passwordForm.Controls.Add(labelConfirmPassword);
                                        passwordForm.Controls.Add(textConfirmPassword);
                                        passwordForm.Controls.Add(btnSave);

                                        if (passwordForm.ShowDialog() == DialogResult.OK)
                                        {
                                            string newPassword = textNewPassword.Text.Trim();
                                            string confirmPassword = textConfirmPassword.Text.Trim();

                                            // Validate that the passwords match
                                            if (newPassword != confirmPassword)
                                            {
                                                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }

                                            // Update the password in the database
                                            string updateQuery = "UPDATE accounts SET password = @password WHERE username = @username";
                                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                            {
                                                updateCmd.Parameters.AddWithValue("@password", newPassword); // Consider hashing the password for security
                                                updateCmd.Parameters.AddWithValue("@username", username);

                                                updateCmd.ExecuteNonQuery();
                                            }

                                            MessageBox.Show($"Password successfully changed for {name}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {
                                    // Recovery pin is incorrect
                                    MessageBox.Show("Wrong security credentials entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                // Username does not exist
                                MessageBox.Show("Cannot find account with the entered username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
