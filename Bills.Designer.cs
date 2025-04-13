namespace PetAppointment
{
    partial class Bills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.schedAppointment = new System.Windows.Forms.Button();
            this.RecordBills = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBillStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.textbillAppointmentId = new System.Windows.Forms.TextBox();
            this.labelfname = new System.Windows.Forms.Label();
            this.ScheduleAppointmentlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.RegisterPet = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            this.RegisterOwner = new System.Windows.Forms.Button();
            this.AddTreatments = new System.Windows.Forms.Button();
            this.VetDoctor = new System.Windows.Forms.Button();
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_appointment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treatment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatment_appointment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatment_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(399, 463);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(149, 59);
            this.Delete.TabIndex = 81;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(399, 371);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(149, 59);
            this.Update.TabIndex = 80;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.LightBlue;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(227, 371);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(149, 59);
            this.Add.TabIndex = 78;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // New
            // 
            this.New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(227, 463);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(149, 59);
            this.New.TabIndex = 79;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            // 
            // schedAppointment
            // 
            this.schedAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schedAppointment.BackColor = System.Drawing.Color.LightPink;
            this.schedAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schedAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedAppointment.Location = new System.Drawing.Point(17, 85);
            this.schedAppointment.Name = "schedAppointment";
            this.schedAppointment.Size = new System.Drawing.Size(150, 82);
            this.schedAppointment.TabIndex = 14;
            this.schedAppointment.Text = "Appointment";
            this.schedAppointment.UseVisualStyleBackColor = false;
            this.schedAppointment.Click += new System.EventHandler(this.schedAppointment_Click);
            // 
            // RecordBills
            // 
            this.RecordBills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecordBills.BackColor = System.Drawing.Color.HotPink;
            this.RecordBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBills.Location = new System.Drawing.Point(17, 580);
            this.RecordBills.Name = "RecordBills";
            this.RecordBills.Size = new System.Drawing.Size(150, 35);
            this.RecordBills.TabIndex = 13;
            this.RecordBills.Text = "Record Bills";
            this.RecordBills.UseVisualStyleBackColor = false;
            this.RecordBills.Click += new System.EventHandler(this.RecordBills_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(968, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Bills Record";
            // 
            // textBillStatus
            // 
            this.textBillStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBillStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBillStatus.Location = new System.Drawing.Point(227, 287);
            this.textBillStatus.MaxLength = 11;
            this.textBillStatus.Name = "textBillStatus";
            this.textBillStatus.Size = new System.Drawing.Size(299, 30);
            this.textBillStatus.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Bill Status:";
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(222, 171);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(236, 25);
            this.lname.TabIndex = 72;
            this.lname.Text = "Total Cost (to be paid):";
            // 
            // textbillAppointmentId
            // 
            this.textbillAppointmentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbillAppointmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbillAppointmentId.Location = new System.Drawing.Point(227, 111);
            this.textbillAppointmentId.Name = "textbillAppointmentId";
            this.textbillAppointmentId.Size = new System.Drawing.Size(299, 30);
            this.textbillAppointmentId.TabIndex = 71;
            // 
            // labelfname
            // 
            this.labelfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(222, 83);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(164, 25);
            this.labelfname.TabIndex = 70;
            this.labelfname.Text = "Appointment Id:";
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(698, 22);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(229, 42);
            this.ScheduleAppointmentlabel.TabIndex = 69;
            this.ScheduleAppointmentlabel.Text = "Record Bills";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.schedAppointment);
            this.panel1.Controls.Add(this.RecordBills);
            this.panel1.Controls.Add(this.RegisterPet);
            this.panel1.Controls.Add(this.AddStaff);
            this.panel1.Controls.Add(this.RegisterOwner);
            this.panel1.Controls.Add(this.AddTreatments);
            this.panel1.Controls.Add(this.VetDoctor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 894);
            this.panel1.TabIndex = 68;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(17, 744);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 35);
            this.exit.TabIndex = 15;
            this.exit.Text = "Log Out";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RegisterPet
            // 
            this.RegisterPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPet.BackColor = System.Drawing.Color.LightPink;
            this.RegisterPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPet.Location = new System.Drawing.Point(17, 372);
            this.RegisterPet.Name = "RegisterPet";
            this.RegisterPet.Size = new System.Drawing.Size(150, 35);
            this.RegisterPet.TabIndex = 9;
            this.RegisterPet.Text = "Register Pet";
            this.RegisterPet.UseVisualStyleBackColor = false;
            this.RegisterPet.Click += new System.EventHandler(this.RegisterPet_Click);
            // 
            // AddStaff
            // 
            this.AddStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStaff.BackColor = System.Drawing.Color.LightPink;
            this.AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStaff.Location = new System.Drawing.Point(17, 529);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(150, 35);
            this.AddStaff.TabIndex = 12;
            this.AddStaff.Text = "Add Staff";
            this.AddStaff.UseVisualStyleBackColor = false;
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // RegisterOwner
            // 
            this.RegisterOwner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterOwner.BackColor = System.Drawing.Color.LightPink;
            this.RegisterOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterOwner.Location = new System.Drawing.Point(17, 318);
            this.RegisterOwner.Name = "RegisterOwner";
            this.RegisterOwner.Size = new System.Drawing.Size(150, 35);
            this.RegisterOwner.TabIndex = 8;
            this.RegisterOwner.Text = "Register Owner";
            this.RegisterOwner.UseVisualStyleBackColor = false;
            this.RegisterOwner.Click += new System.EventHandler(this.RegisterOwner_Click);
            // 
            // AddTreatments
            // 
            this.AddTreatments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTreatments.BackColor = System.Drawing.Color.LightPink;
            this.AddTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTreatments.Location = new System.Drawing.Point(17, 478);
            this.AddTreatments.Name = "AddTreatments";
            this.AddTreatments.Size = new System.Drawing.Size(150, 35);
            this.AddTreatments.TabIndex = 11;
            this.AddTreatments.Text = "Treatment";
            this.AddTreatments.UseVisualStyleBackColor = false;
            this.AddTreatments.Click += new System.EventHandler(this.AddTreatments_Click);
            // 
            // VetDoctor
            // 
            this.VetDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VetDoctor.BackColor = System.Drawing.Color.LightPink;
            this.VetDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetDoctor.Location = new System.Drawing.Point(17, 427);
            this.VetDoctor.Name = "VetDoctor";
            this.VetDoctor.Size = new System.Drawing.Size(150, 35);
            this.VetDoctor.TabIndex = 10;
            this.VetDoctor.Text = "Vet Doctor";
            this.VetDoctor.UseVisualStyleBackColor = false;
            this.VetDoctor.Click += new System.EventHandler(this.VetDoctor_Click);
            // 
            // appointmentList
            // 
            this.appointmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointmentList.BackgroundColor = System.Drawing.Color.LightPink;
            this.appointmentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bill_id,
            this.bill_appointment_id,
            this.bill_total_cost,
            this.bill_status});
            this.appointmentList.Location = new System.Drawing.Point(610, 111);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.RowHeadersWidth = 51;
            this.appointmentList.RowTemplate.Height = 24;
            this.appointmentList.Size = new System.Drawing.Size(860, 307);
            this.appointmentList.TabIndex = 76;
            // 
            // bill_id
            // 
            this.bill_id.HeaderText = "Bill Id";
            this.bill_id.MinimumWidth = 6;
            this.bill_id.Name = "bill_id";
            this.bill_id.Width = 125;
            // 
            // bill_appointment_id
            // 
            this.bill_appointment_id.HeaderText = "Appointment id";
            this.bill_appointment_id.MinimumWidth = 6;
            this.bill_appointment_id.Name = "bill_appointment_id";
            this.bill_appointment_id.Width = 125;
            // 
            // bill_total_cost
            // 
            this.bill_total_cost.HeaderText = "Total Cost";
            this.bill_total_cost.MinimumWidth = 6;
            this.bill_total_cost.Name = "bill_total_cost";
            this.bill_total_cost.Width = 125;
            // 
            // bill_status
            // 
            this.bill_status.HeaderText = "Bill Status";
            this.bill_status.MinimumWidth = 6;
            this.bill_status.Name = "bill_status";
            this.bill_status.Width = 125;
            // 
            // textTotalCost
            // 
            this.textTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalCost.Location = new System.Drawing.Point(227, 199);
            this.textTotalCost.Name = "textTotalCost";
            this.textTotalCost.Size = new System.Drawing.Size(299, 30);
            this.textTotalCost.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatment_id,
            this.treatment_appointment_id,
            this.treatment_description,
            this.medication,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(610, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 388);
            this.dataGridView1.TabIndex = 83;
            // 
            // treatment_id
            // 
            this.treatment_id.HeaderText = "Treatment ID";
            this.treatment_id.MinimumWidth = 6;
            this.treatment_id.Name = "treatment_id";
            this.treatment_id.Width = 125;
            // 
            // treatment_appointment_id
            // 
            this.treatment_appointment_id.HeaderText = "Appointment Id";
            this.treatment_appointment_id.MinimumWidth = 6;
            this.treatment_appointment_id.Name = "treatment_appointment_id";
            this.treatment_appointment_id.Width = 125;
            // 
            // treatment_description
            // 
            this.treatment_description.HeaderText = "Treatment Description";
            this.treatment_description.MinimumWidth = 6;
            this.treatment_description.Name = "treatment_description";
            this.treatment_description.Width = 125;
            // 
            // medication
            // 
            this.medication.HeaderText = "Medication";
            this.medication.MinimumWidth = 6;
            this.medication.Name = "medication";
            this.medication.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 125;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(968, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Treatment Record";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.New);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBillStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.textbillAppointmentId);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.appointmentList);
            this.Controls.Add(this.textTotalCost);
            this.MinimumSize = new System.Drawing.Size(1500, 940);
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button schedAppointment;
        private System.Windows.Forms.Button RecordBills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBillStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox textbillAppointmentId;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label ScheduleAppointmentlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button RegisterPet;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.Button RegisterOwner;
        private System.Windows.Forms.Button AddTreatments;
        private System.Windows.Forms.Button VetDoctor;
        private System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_appointment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatment_appointment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatment_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn medication;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Label label2;
    }
}