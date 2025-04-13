namespace PetAppointment
{
    partial class Vet
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
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.textspecialization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textvetLname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.textvetFname = new System.Windows.Forms.TextBox();
            this.ScheduleAppointmentlabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.schedAppointment = new System.Windows.Forms.Button();
            this.RecordBills = new System.Windows.Forms.Button();
            this.RegisterPet = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            this.RegisterOwner = new System.Windows.Forms.Button();
            this.AddTreatments = new System.Windows.Forms.Button();
            this.VetDoctor = new System.Windows.Forms.Button();
            this.labelfname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vet_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vet_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(955, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Registered Vet";
            // 
            // appointmentList
            // 
            this.appointmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointmentList.BackgroundColor = System.Drawing.Color.LightPink;
            this.appointmentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vet_id,
            this.vet_first_name,
            this.vet_last_name,
            this.owner_phone,
            this.specialization});
            this.appointmentList.Location = new System.Drawing.Point(597, 220);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.RowHeadersWidth = 51;
            this.appointmentList.RowTemplate.Height = 24;
            this.appointmentList.Size = new System.Drawing.Size(860, 581);
            this.appointmentList.TabIndex = 38;
            // 
            // textspecialization
            // 
            this.textspecialization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textspecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textspecialization.Location = new System.Drawing.Point(228, 484);
            this.textspecialization.MaxLength = 11;
            this.textspecialization.Name = "textspecialization";
            this.textspecialization.Size = new System.Drawing.Size(299, 30);
            this.textspecialization.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Specialization:";
            // 
            // textphone
            // 
            this.textphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textphone.Location = new System.Drawing.Point(228, 396);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(299, 30);
            this.textphone.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Phone:";
            // 
            // textvetLname
            // 
            this.textvetLname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textvetLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvetLname.Location = new System.Drawing.Point(228, 308);
            this.textvetLname.Name = "textvetLname";
            this.textvetLname.Size = new System.Drawing.Size(299, 30);
            this.textvetLname.TabIndex = 32;
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(223, 280);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(122, 25);
            this.lname.TabIndex = 31;
            this.lname.Text = "Last Name:";
            // 
            // textvetFname
            // 
            this.textvetFname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textvetFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvetFname.Location = new System.Drawing.Point(228, 220);
            this.textvetFname.Name = "textvetFname";
            this.textvetFname.Size = new System.Drawing.Size(299, 30);
            this.textvetFname.TabIndex = 30;
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(565, 45);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(459, 42);
            this.ScheduleAppointmentlabel.TabIndex = 28;
            this.ScheduleAppointmentlabel.Text = "Register Vet information";
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
            this.RecordBills.BackColor = System.Drawing.Color.LightPink;
            this.RecordBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBills.Location = new System.Drawing.Point(17, 580);
            this.RecordBills.Name = "RecordBills";
            this.RecordBills.Size = new System.Drawing.Size(150, 35);
            this.RecordBills.TabIndex = 13;
            this.RecordBills.Text = "Record Bills";
            this.RecordBills.UseVisualStyleBackColor = false;
            this.RecordBills.Click += new System.EventHandler(this.RecordBills_Click);
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
            this.VetDoctor.BackColor = System.Drawing.Color.HotPink;
            this.VetDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetDoctor.Location = new System.Drawing.Point(17, 427);
            this.VetDoctor.Name = "VetDoctor";
            this.VetDoctor.Size = new System.Drawing.Size(150, 35);
            this.VetDoctor.TabIndex = 10;
            this.VetDoctor.Text = "Vet Doctor";
            this.VetDoctor.UseVisualStyleBackColor = false;
            this.VetDoctor.Click += new System.EventHandler(this.VetDoctor_Click);
            // 
            // labelfname
            // 
            this.labelfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(223, 192);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(123, 25);
            this.labelfname.TabIndex = 29;
            this.labelfname.Text = "First Name:";
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 894);
            this.panel1.TabIndex = 27;
            // 
            // vet_id
            // 
            this.vet_id.HeaderText = "Vet Id";
            this.vet_id.MinimumWidth = 6;
            this.vet_id.Name = "vet_id";
            this.vet_id.Width = 125;
            // 
            // vet_first_name
            // 
            this.vet_first_name.HeaderText = "First Name";
            this.vet_first_name.MinimumWidth = 6;
            this.vet_first_name.Name = "vet_first_name";
            this.vet_first_name.Width = 125;
            // 
            // vet_last_name
            // 
            this.vet_last_name.HeaderText = "Last Name";
            this.vet_last_name.MinimumWidth = 6;
            this.vet_last_name.Name = "vet_last_name";
            this.vet_last_name.Width = 125;
            // 
            // owner_phone
            // 
            this.owner_phone.HeaderText = "Phone";
            this.owner_phone.MinimumWidth = 6;
            this.owner_phone.Name = "owner_phone";
            this.owner_phone.Width = 125;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "Specialization";
            this.specialization.MinimumWidth = 6;
            this.specialization.Name = "specialization";
            this.specialization.Width = 125;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(400, 661);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(149, 59);
            this.Delete.TabIndex = 67;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(400, 569);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(149, 59);
            this.Update.TabIndex = 66;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // New
            // 
            this.New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(228, 661);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(149, 59);
            this.New.TabIndex = 65;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.LightBlue;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(228, 569);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(149, 59);
            this.Add.TabIndex = 64;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Vet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentList);
            this.Controls.Add(this.textspecialization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvetLname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.textvetFname);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1500, 940);
            this.Name = "Vet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vet";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.TextBox textspecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textvetLname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox textvetFname;
        private System.Windows.Forms.Label ScheduleAppointmentlabel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button schedAppointment;
        private System.Windows.Forms.Button RecordBills;
        private System.Windows.Forms.Button RegisterPet;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.Button RegisterOwner;
        private System.Windows.Forms.Button AddTreatments;
        private System.Windows.Forms.Button VetDoctor;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vet_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vet_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
    }
}