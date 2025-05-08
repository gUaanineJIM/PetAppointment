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
    public partial class BackupData : Form
    {
        public BackupData()
        {
            InitializeComponent();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adminAccount = new Admin();
            adminAccount.Show();
            this.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAcc manageAcc = new ManageAcc();
            manageAcc.Show();
            this.Close();
        }

        private async void backupAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait while the backup is processing...", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await Task.Run(() =>
            {
                string filePath = @"D:\Janine Ishe\College\BSIT 3rd Year\EDP\ACT7\PetAppointment\bin\Debug\ReportTemplate\vetBackup.xlsx";

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
    }
}
