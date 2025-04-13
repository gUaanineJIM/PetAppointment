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
    public partial class ScheduleAppointment : Form
    {
        public ScheduleAppointment()
        {
            InitializeComponent();
        }

        private void ScheduleAppointment_Load(object sender, EventArgs e)
        {

        }

        private void VetDoctor_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
            this.Close();
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
            Bills bills = new Bills();
            bills.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textReasonofVisit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textPetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void texStaffId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScheduleAppointmentlabel_Click(object sender, EventArgs e)
        {

        }

        private void idpet_Click(object sender, EventArgs e)
        {

        }

        private void VetId_Click(object sender, EventArgs e)
        {

        }

        private void StaffId_Click(object sender, EventArgs e)
        {

        }

        private void ReasonofVisit_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void texTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
