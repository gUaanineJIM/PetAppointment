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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Hide();
        }
    }
}
