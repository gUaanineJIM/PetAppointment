using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace PetAppointment
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashlabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleAppointment ScheduleAppointment = new ScheduleAppointment();
            ScheduleAppointment.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPets registerPets = new RegisterPets();
            registerPets.Show();
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

        private void AddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

        private void AddTreatments_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Close();
        }

        private void RecordBills_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginAcc loginAcc = new LoginAcc();
            loginAcc.Show();
            this.Close();
        }

        private async void backupAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait while the backup is processing...", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await Task.Run(() =>
            {
                // Use a relative path to locate the backup file
                string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportTemplate", "vetBackup.xlsx");

                Excel.Application excelApp = null;
                Excel.Workbook workbook = null;

                try
                {
                    excelApp = new Excel.Application();
                    excelApp.DisplayAlerts = false;

                    workbook = excelApp.Workbooks.Open(filePath);

                    BackupTableToSheet(workbook, "accounts", "SELECT id, name, username, password, sec_question FROM accounts", "A3");
                    BackupTableToSheet(workbook, "appointments", "SELECT appointment_id, pet_id, vet_id, staff_id, appointment_date, appointment_time, reason FROM appointments", "A3");
                    BackupTableToSheet(workbook, "bills", "SELECT bill_id, appointment_id, total_cost, bill_status FROM bills", "A3");
                    BackupTableToSheet(workbook, "owners", "SELECT owner_id, first_name, last_name, phone, address FROM owners", "A3");
                    BackupTableToSheet(workbook, "pets", "SELECT pet_id, name, animal_type, description, age, owner_id FROM pets", "A3");
                    BackupTableToSheet(workbook, "staff", "SELECT staff_id, first_name, last_name, phone FROM staff", "A3");
                    BackupTableToSheet(workbook, "treatment", "SELECT treatment_id, appointment_id, treatment_description, medication, cost FROM treatment", "A3");
                    BackupTableToSheet(workbook, "appointment_logs", "SELECT log_id, appointment_id, pet_id, vet_id, action, action_time FROM appointment_logs", "A3");

                    workbook.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Release COM objects
                    if (workbook != null)
                    {
                        workbook.Close(false);
                        Marshal.ReleaseComObject(workbook);
                    }
                    if (excelApp != null)
                    {
                        excelApp.Quit();
                        Marshal.ReleaseComObject(excelApp);
                    }

                    workbook = null;
                    excelApp = null;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            });

            MessageBox.Show("Backup completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void BackupTableToSheet(Excel.Workbook workbook, string sheetName, string query, string startCell)
        {
            Excel.Worksheet worksheet = null;
            MySqlConnection conn = null;

            try
            {
                //Get the worksheet
                worksheet = workbook.Sheets[sheetName] as Excel.Worksheet;
                if (worksheet == null)
                {
                    MessageBox.Show($"The '{sheetName}' sheet does not exist in the Excel file.");
                    return;
                }

                //get data from the database
                string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                
                Excel.Range startRange = worksheet.Range[startCell];
                int row = startRange.Row;
                int col = startRange.Column;

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        worksheet.Cells[row, col + i].Value = reader.GetValue(i);
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error backing up table to sheet '{sheetName}': {ex.Message}");
            }
            finally
            {
                // Release COM objects
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (conn != null) conn.Close();
            }
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
            RegisterPets registerPets = new RegisterPets();
            registerPets.Show();
            this.Close();
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
