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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
            LoadTreatment();
            LoadBills();
        }

        private void RecordBills_Click(object sender, EventArgs e)
        {
            
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

        private void VetDoctor_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
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

        private void schedAppointment_Click(object sender, EventArgs e)
        {
            ScheduleAppointment ScheduleAppointment = new ScheduleAppointment();
            ScheduleAppointment.Show();
            this.Close();
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

        private void appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //function to load the bills
        private void LoadBills()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM bills";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    billsList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void treatmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //function to load the treatment list
        private void LoadTreatment()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get treatments without bills
                    string query = @"
                SELECT 
                    t.treatment_id AS TreatmentID,
                    t.appointment_id AS AppointmentID,
                    t.treatment_description AS TreatmentDescription,
                    t.medication AS Medication,
                    t.cost AS Cost
                FROM treatment t
                LEFT JOIN bills b ON t.appointment_id = b.appointment_id
                WHERE b.bill_id IS NULL";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    treatmentList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void paidbtn_Click(object sender, EventArgs e)
        {
            textBillStatus.Text = "Paid";
        }

        private void unpaidbtn_Click(object sender, EventArgs e)
        {
            textBillStatus.Text = "Unpaid";
        }


        private void textTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbillAppointmentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBillStatus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from input fields
            string appointmentIdText = textbillAppointmentId.Text.Trim();
            string totalCostText = textTotalCost.Text.Trim();
            string billStatus = textBillStatus.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(appointmentIdText) || string.IsNullOrEmpty(totalCostText) || string.IsNullOrEmpty(billStatus))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(appointmentIdText, out int appointmentId))
            {
                MessageBox.Show("Invalid Appointment ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(totalCostText, out decimal totalCost))
            {
                MessageBox.Show("Invalid Total Cost. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (billStatus != "Paid" && billStatus != "Unpaid")
            {
                MessageBox.Show("Bill Status must be either 'Paid' or 'Unpaid'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the appointment_id exists in the treatment table
            if (!IsAppointmentInTreatment(appointmentId))
            {
                MessageBox.Show("The Appointment ID exists but does not have a treatment record. Please add a treatment record first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate appointment_id in the bills table
            if (IsDuplicateBill(appointmentId))
            {
                MessageBox.Show("A bill already exists for this Appointment ID. Please use a different Appointment ID.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert the new bill into the database
            AddNewBill(appointmentId, totalCost, billStatus);

            // Clear the input fields after adding
            ClearBillFields();

            // Reload the bills list (if applicable)
            LoadBills();
        }

        private bool IsAppointmentInTreatment(int appointmentId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool exists = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM treatment WHERE appointment_id = @appointmentId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return exists;
        }

        private bool IsDuplicateBill(int appointmentId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM bills WHERE appointment_id = @appointmentId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isDuplicate = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isDuplicate;
        }

        private void AddNewBill(int appointmentId, decimal totalCost, string billStatus)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO bills (appointment_id, total_cost, bill_status) VALUES (@appointmentId, @totalCost, @billStatus)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    cmd.Parameters.AddWithValue("@totalCost", totalCost);
                    cmd.Parameters.AddWithValue("@billStatus", billStatus);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearBillFields()
        {
            textbillAppointmentId.Clear();
            textTotalCost.Clear();
            textBillStatus.Clear();
        }

        private void New_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            textbillAppointmentId.Clear();
            textTotalCost.Clear();
            textBillStatus.Clear();
        }



        private void Bills_Load(object sender, EventArgs e)
        {

        }

        private void billsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid (not a header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = billsList.Rows[e.RowIndex];

                // Populate the input fields with the selected row's data
                textbillAppointmentId.Text = selectedRow.Cells["appointment_id"].Value?.ToString() ?? string.Empty;
                textTotalCost.Text = selectedRow.Cells["total_cost"].Value?.ToString() ?? string.Empty;
                textBillStatus.Text = selectedRow.Cells["bill_status"].Value?.ToString() ?? string.Empty;

                // Store the bill_id in the Tag property for reference during the update
                textbillAppointmentId.Tag = selectedRow.Cells["bill_id"].Value;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Ensure a bill is selected for updating
            if (textbillAppointmentId.Tag == null || !int.TryParse(textbillAppointmentId.Tag.ToString(), out int billId))
            {
                MessageBox.Show("Please select a bill to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get updated values from input fields
            string appointmentIdText = textbillAppointmentId.Text.Trim();
            string totalCostText = textTotalCost.Text.Trim();
            string billStatus = textBillStatus.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(appointmentIdText) || string.IsNullOrEmpty(totalCostText) || string.IsNullOrEmpty(billStatus))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(appointmentIdText, out int appointmentId))
            {
                MessageBox.Show("Invalid Appointment ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(totalCostText, out decimal totalCost))
            {
                MessageBox.Show("Invalid Total Cost. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (billStatus != "Paid" && billStatus != "Unpaid")
            {
                MessageBox.Show("Bill Status must be either 'Paid' or 'Unpaid'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate appointment_id in the bills table (excluding the current bill)
            if (IsDuplicateAppointmentId(appointmentId, billId))
            {
                MessageBox.Show("The Appointment ID is already associated with another bill. Please use a different Appointment ID.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the bill in the database
            UpdateBill(billId, appointmentId, totalCost, billStatus);

            // Clear the input fields after updating
            ClearBillFields();

            // Reload the bills list
            LoadBills();
        }

        private bool IsDuplicateAppointmentId(int appointmentId, int excludeBillId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isDuplicate = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT COUNT(*) 
                FROM bills 
                WHERE appointment_id = @appointmentId AND bill_id != @excludeBillId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    cmd.Parameters.AddWithValue("@excludeBillId", excludeBillId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isDuplicate = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isDuplicate;
        }




        private void UpdateBill(int billId, int appointmentId, decimal totalCost, string billStatus)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE bills 
                SET appointment_id = @appointmentId, 
                    total_cost = @totalCost, 
                    bill_status = @billStatus 
                WHERE bill_id = @billId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@billId", billId);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    cmd.Parameters.AddWithValue("@totalCost", totalCost);
                    cmd.Parameters.AddWithValue("@billStatus", billStatus);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Ensure a bill is selected for deletion
            if (textbillAppointmentId.Tag == null || !int.TryParse(textbillAppointmentId.Tag.ToString(), out int billId))
            {
                MessageBox.Show("Please select a bill to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the bill is marked as "Paid"
            if (IsPaidBill(billId))
            {
                MessageBox.Show("Paid bills cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this bill?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the bill from the database
                DeleteBill(billId);

                // Clear the input fields after deletion
                ClearBillFields();

                // Reload the bills list
                LoadBills();
            }
        }

        private bool IsPaidBill(int billId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";
            bool isPaid = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT bill_status FROM bills WHERE bill_id = @billId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@billId", billId);

                    string status = cmd.ExecuteScalar()?.ToString();
                    isPaid = status == "Paid";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isPaid;
        }



        private void DeleteBill(int billId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM bills WHERE bill_id = @billId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@billId", billId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void staffIdSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            // Get the bill ID from the search text box
            string billIdText = staffIdSearch.Text.Trim();

            // Validate the input
            if (string.IsNullOrEmpty(billIdText))
            {
                MessageBox.Show("Please enter a Bill ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(billIdText, out int billId))
            {
                MessageBox.Show("Invalid Bill ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search for the bill in the database
            FindBillById(billId);
        }
        private void FindBillById(int billId)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=vet_record;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT appointment_id, total_cost, bill_status FROM bills WHERE bill_id = @billId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@billId", billId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the retrieved data
                            textbillAppointmentId.Text = reader["appointment_id"].ToString();
                            textTotalCost.Text = reader["total_cost"].ToString();
                            textBillStatus.Text = reader["bill_status"].ToString();

                            // Store the bill_id in the Tag property for reference
                            textbillAppointmentId.Tag = billId;

                           
                        }
                        else
                        {
                            MessageBox.Show("No bill found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
