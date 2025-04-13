using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Welcome back, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dashboard dashboard = new dashboard();
                dashboard.Show();

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
