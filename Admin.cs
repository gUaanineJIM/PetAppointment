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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }


        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAcc manageAcc = new ManageAcc();
            manageAcc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Close();
        }

        private void backupTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupData backupData = new BackupData();
            backupData.Show();
            this.Close();
        }
    }
}
