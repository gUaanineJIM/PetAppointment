namespace PetAppointment
{
    partial class ScheduleAppointment
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
            this.ScheduleAppointmentlabel = new System.Windows.Forms.Label();
            this.idpet = new System.Windows.Forms.Label();
            this.VetId = new System.Windows.Forms.Label();
            this.StaffId = new System.Windows.Forms.Label();
            this.ReasonofVisit = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.textPetId = new System.Windows.Forms.TextBox();
            this.textVetId = new System.Windows.Forms.TextBox();
            this.texStaffId = new System.Windows.Forms.TextBox();
            this.textReasonofVisit = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.texTime = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.petList = new System.Windows.Forms.DataGridView();
            this.pet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetList = new System.Windows.Forms.DataGridView();
            this.vet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffList = new System.Windows.Forms.Label();
            this.VetDoctor = new System.Windows.Forms.Button();
            this.AddTreatments = new System.Windows.Forms.Button();
            this.RegisterOwner = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            this.RegisterPet = new System.Windows.Forms.Button();
            this.RecordBills = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.schedAppointment = new System.Windows.Forms.Button();
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.appointment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_pet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_vet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.petList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(648, 8);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(417, 42);
            this.ScheduleAppointmentlabel.TabIndex = 0;
            this.ScheduleAppointmentlabel.Text = "Schedule Appointment";
            this.ScheduleAppointmentlabel.Click += new System.EventHandler(this.ScheduleAppointmentlabel_Click);
            // 
            // idpet
            // 
            this.idpet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idpet.AutoSize = true;
            this.idpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpet.Location = new System.Drawing.Point(213, 70);
            this.idpet.Name = "idpet";
            this.idpet.Size = new System.Drawing.Size(75, 25);
            this.idpet.TabIndex = 1;
            this.idpet.Text = "Pet Id:";
            this.idpet.Click += new System.EventHandler(this.idpet_Click);
            // 
            // VetId
            // 
            this.VetId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VetId.AutoSize = true;
            this.VetId.CausesValidation = false;
            this.VetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetId.Location = new System.Drawing.Point(536, 70);
            this.VetId.Name = "VetId";
            this.VetId.Size = new System.Drawing.Size(76, 25);
            this.VetId.TabIndex = 2;
            this.VetId.Text = "Vet Id:";
            this.VetId.Click += new System.EventHandler(this.VetId_Click);
            // 
            // StaffId
            // 
            this.StaffId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffId.AutoSize = true;
            this.StaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffId.Location = new System.Drawing.Point(850, 70);
            this.StaffId.Name = "StaffId";
            this.StaffId.Size = new System.Drawing.Size(88, 25);
            this.StaffId.TabIndex = 3;
            this.StaffId.Text = "Staff Id:";
            this.StaffId.Click += new System.EventHandler(this.StaffId_Click);
            // 
            // ReasonofVisit
            // 
            this.ReasonofVisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReasonofVisit.AutoSize = true;
            this.ReasonofVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonofVisit.Location = new System.Drawing.Point(213, 147);
            this.ReasonofVisit.Name = "ReasonofVisit";
            this.ReasonofVisit.Size = new System.Drawing.Size(164, 25);
            this.ReasonofVisit.TabIndex = 4;
            this.ReasonofVisit.Text = "Reason of Visit:";
            this.ReasonofVisit.Click += new System.EventHandler(this.ReasonofVisit_Click);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(536, 147);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(64, 25);
            this.date.TabIndex = 5;
            this.date.Text = "Date:";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // textPetId
            // 
            this.textPetId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPetId.Location = new System.Drawing.Point(218, 98);
            this.textPetId.Name = "textPetId";
            this.textPetId.Size = new System.Drawing.Size(299, 30);
            this.textPetId.TabIndex = 6;
            this.textPetId.TextChanged += new System.EventHandler(this.textPetId_TextChanged);
            // 
            // textVetId
            // 
            this.textVetId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textVetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVetId.Location = new System.Drawing.Point(541, 98);
            this.textVetId.Name = "textVetId";
            this.textVetId.Size = new System.Drawing.Size(299, 30);
            this.textVetId.TabIndex = 7;
            this.textVetId.TextChanged += new System.EventHandler(this.textVetId_TextChanged);
            // 
            // texStaffId
            // 
            this.texStaffId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texStaffId.Location = new System.Drawing.Point(855, 98);
            this.texStaffId.Name = "texStaffId";
            this.texStaffId.Size = new System.Drawing.Size(299, 30);
            this.texStaffId.TabIndex = 8;
            this.texStaffId.TextChanged += new System.EventHandler(this.texStaffId_TextChanged);
            // 
            // textReasonofVisit
            // 
            this.textReasonofVisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textReasonofVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReasonofVisit.Location = new System.Drawing.Point(218, 175);
            this.textReasonofVisit.Name = "textReasonofVisit";
            this.textReasonofVisit.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textReasonofVisit.Size = new System.Drawing.Size(299, 30);
            this.textReasonofVisit.TabIndex = 9;
            this.textReasonofVisit.TextChanged += new System.EventHandler(this.textReasonofVisit_TextChanged);
            // 
            // textDate
            // 
            this.textDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(541, 175);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(299, 30);
            this.textDate.TabIndex = 10;
            this.textDate.TextChanged += new System.EventHandler(this.textDate_TextChanged);
            // 
            // texTime
            // 
            this.texTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTime.Location = new System.Drawing.Point(855, 175);
            this.texTime.Name = "texTime";
            this.texTime.Size = new System.Drawing.Size(299, 30);
            this.texTime.TabIndex = 12;
            this.texTime.TextChanged += new System.EventHandler(this.texTime_TextChanged);
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(850, 147);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(67, 25);
            this.Time.TabIndex = 11;
            this.Time.Text = "Time:";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // petList
            // 
            this.petList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.petList.BackgroundColor = System.Drawing.Color.White;
            this.petList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pet_id,
            this.name});
            this.petList.Location = new System.Drawing.Point(200, 312);
            this.petList.Name = "petList";
            this.petList.RowHeadersWidth = 51;
            this.petList.RowTemplate.Height = 24;
            this.petList.Size = new System.Drawing.Size(299, 527);
            this.petList.TabIndex = 17;
            this.petList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pet_id
            // 
            this.pet_id.HeaderText = "Pet Id";
            this.pet_id.MinimumWidth = 6;
            this.pet_id.Name = "pet_id";
            this.pet_id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // vetList
            // 
            this.vetList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vetList.BackgroundColor = System.Drawing.Color.White;
            this.vetList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vet_id,
            this.vetLastName,
            this.specialization});
            this.vetList.Location = new System.Drawing.Point(506, 596);
            this.vetList.Name = "vetList";
            this.vetList.RowHeadersWidth = 51;
            this.vetList.RowTemplate.Height = 24;
            this.vetList.Size = new System.Drawing.Size(499, 243);
            this.vetList.TabIndex = 18;
            this.vetList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // vet_id
            // 
            this.vet_id.HeaderText = "Vet id";
            this.vet_id.MinimumWidth = 6;
            this.vet_id.Name = "vet_id";
            this.vet_id.Width = 125;
            // 
            // vetLastName
            // 
            this.vetLastName.HeaderText = "last_name";
            this.vetLastName.MinimumWidth = 6;
            this.vetLastName.Name = "vetLastName";
            this.vetLastName.Width = 125;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "specialization";
            this.specialization.MinimumWidth = 6;
            this.specialization.Name = "specialization";
            this.specialization.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.staffFirstName,
            this.staffLastName});
            this.dataGridView3.Location = new System.Drawing.Point(1011, 596);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(457, 243);
            this.dataGridView3.TabIndex = 19;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "staff_id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // staffFirstName
            // 
            this.staffFirstName.HeaderText = "First Name";
            this.staffFirstName.MinimumWidth = 6;
            this.staffFirstName.Name = "staffFirstName";
            this.staffFirstName.Width = 125;
            // 
            // staffLastName
            // 
            this.staffLastName.HeaderText = "Last Name";
            this.staffLastName.MinimumWidth = 6;
            this.staffLastName.Name = "staffLastName";
            this.staffLastName.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pet List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(735, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vet List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // staffList
            // 
            this.staffList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffList.AutoSize = true;
            this.staffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffList.Location = new System.Drawing.Point(1195, 568);
            this.staffList.Name = "staffList";
            this.staffList.Size = new System.Drawing.Size(97, 25);
            this.staffList.TabIndex = 22;
            this.staffList.Text = "Staff List";
            this.staffList.Click += new System.EventHandler(this.label3_Click);
            // 
            // VetDoctor
            // 
            this.VetDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VetDoctor.BackColor = System.Drawing.Color.Transparent;
            this.VetDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VetDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetDoctor.Location = new System.Drawing.Point(17, 427);
            this.VetDoctor.Name = "VetDoctor";
            this.VetDoctor.Size = new System.Drawing.Size(150, 35);
            this.VetDoctor.TabIndex = 10;
            this.VetDoctor.Text = "Vet Doctor";
            this.VetDoctor.UseVisualStyleBackColor = false;
            this.VetDoctor.Click += new System.EventHandler(this.VetDoctor_Click);
            // 
            // AddTreatments
            // 
            this.AddTreatments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTreatments.BackColor = System.Drawing.Color.Transparent;
            this.AddTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTreatments.Location = new System.Drawing.Point(17, 478);
            this.AddTreatments.Name = "AddTreatments";
            this.AddTreatments.Size = new System.Drawing.Size(150, 35);
            this.AddTreatments.TabIndex = 11;
            this.AddTreatments.Text = "Treatment";
            this.AddTreatments.UseVisualStyleBackColor = false;
            this.AddTreatments.Click += new System.EventHandler(this.AddTreatments_Click);
            // 
            // RegisterOwner
            // 
            this.RegisterOwner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterOwner.BackColor = System.Drawing.Color.Transparent;
            this.RegisterOwner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterOwner.Location = new System.Drawing.Point(17, 318);
            this.RegisterOwner.Name = "RegisterOwner";
            this.RegisterOwner.Size = new System.Drawing.Size(150, 35);
            this.RegisterOwner.TabIndex = 8;
            this.RegisterOwner.Text = "Register Owner";
            this.RegisterOwner.UseVisualStyleBackColor = false;
            this.RegisterOwner.Click += new System.EventHandler(this.RegisterOwner_Click);
            // 
            // AddStaff
            // 
            this.AddStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStaff.BackColor = System.Drawing.Color.Transparent;
            this.AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStaff.Location = new System.Drawing.Point(17, 529);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(150, 35);
            this.AddStaff.TabIndex = 12;
            this.AddStaff.Text = "Add Staff";
            this.AddStaff.UseVisualStyleBackColor = false;
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // RegisterPet
            // 
            this.RegisterPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPet.BackColor = System.Drawing.Color.Transparent;
            this.RegisterPet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPet.Location = new System.Drawing.Point(17, 372);
            this.RegisterPet.Name = "RegisterPet";
            this.RegisterPet.Size = new System.Drawing.Size(150, 35);
            this.RegisterPet.TabIndex = 9;
            this.RegisterPet.Text = "Register Pet";
            this.RegisterPet.UseVisualStyleBackColor = false;
            this.RegisterPet.Click += new System.EventHandler(this.RegisterPet_Click);
            // 
            // RecordBills
            // 
            this.RecordBills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecordBills.BackColor = System.Drawing.Color.Transparent;
            this.RecordBills.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecordBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBills.Location = new System.Drawing.Point(17, 580);
            this.RecordBills.Name = "RecordBills";
            this.RecordBills.Size = new System.Drawing.Size(150, 35);
            this.RecordBills.TabIndex = 13;
            this.RecordBills.Text = "Record Bills";
            this.RecordBills.UseVisualStyleBackColor = false;
            this.RecordBills.Click += new System.EventHandler(this.RecordBills_Click);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightPink;
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
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // schedAppointment
            // 
            this.schedAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schedAppointment.BackColor = System.Drawing.Color.HotPink;
            this.schedAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schedAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schedAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedAppointment.Location = new System.Drawing.Point(17, 85);
            this.schedAppointment.Name = "schedAppointment";
            this.schedAppointment.Size = new System.Drawing.Size(150, 82);
            this.schedAppointment.TabIndex = 14;
            this.schedAppointment.Text = "Appointment";
            this.schedAppointment.UseVisualStyleBackColor = false;
            this.schedAppointment.Click += new System.EventHandler(this.button1_Click);
            // 
            // appointmentList
            // 
            this.appointmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointmentList.BackgroundColor = System.Drawing.Color.White;
            this.appointmentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointment_id,
            this.appointment_pet_id,
            this.appointment_vet_id,
            this.appointment_staff_id,
            this.appointment_reason,
            this.appointment_date,
            this.appointment_time});
            this.appointmentList.Location = new System.Drawing.Point(506, 312);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.RowHeadersWidth = 51;
            this.appointmentList.RowTemplate.Height = 24;
            this.appointmentList.Size = new System.Drawing.Size(962, 253);
            this.appointmentList.TabIndex = 23;
            this.appointmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentList_CellContentClick);
            // 
            // appointment_id
            // 
            this.appointment_id.HeaderText = "Appointment ID";
            this.appointment_id.MinimumWidth = 6;
            this.appointment_id.Name = "appointment_id";
            this.appointment_id.Width = 125;
            // 
            // appointment_pet_id
            // 
            this.appointment_pet_id.HeaderText = "Pet Id";
            this.appointment_pet_id.MinimumWidth = 6;
            this.appointment_pet_id.Name = "appointment_pet_id";
            this.appointment_pet_id.Width = 125;
            // 
            // appointment_vet_id
            // 
            this.appointment_vet_id.HeaderText = "Vet Id";
            this.appointment_vet_id.MinimumWidth = 6;
            this.appointment_vet_id.Name = "appointment_vet_id";
            this.appointment_vet_id.Width = 125;
            // 
            // appointment_staff_id
            // 
            this.appointment_staff_id.HeaderText = "Staff Id";
            this.appointment_staff_id.MinimumWidth = 6;
            this.appointment_staff_id.Name = "appointment_staff_id";
            this.appointment_staff_id.Width = 125;
            // 
            // appointment_reason
            // 
            this.appointment_reason.HeaderText = "Reason";
            this.appointment_reason.MinimumWidth = 6;
            this.appointment_reason.Name = "appointment_reason";
            this.appointment_reason.Width = 125;
            // 
            // appointment_date
            // 
            this.appointment_date.HeaderText = "Date";
            this.appointment_date.MinimumWidth = 6;
            this.appointment_date.Name = "appointment_date";
            this.appointment_date.Width = 125;
            // 
            // appointment_time
            // 
            this.appointment_time.HeaderText = "Time";
            this.appointment_time.MinimumWidth = 6;
            this.appointment_time.Name = "appointment_time";
            this.appointment_time.Width = 125;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Appointment List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.HotPink;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1333, 166);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 48);
            this.Delete.TabIndex = 63;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.HotPink;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(1333, 89);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 48);
            this.Update.TabIndex = 62;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // New
            // 
            this.New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New.BackColor = System.Drawing.Color.HotPink;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(1200, 166);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 48);
            this.New.TabIndex = 61;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.HotPink;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1200, 89);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 60;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentList);
            this.Controls.Add(this.staffList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.vetList);
            this.Controls.Add(this.petList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.texTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textReasonofVisit);
            this.Controls.Add(this.texStaffId);
            this.Controls.Add(this.textVetId);
            this.Controls.Add(this.textPetId);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ReasonofVisit);
            this.Controls.Add(this.StaffId);
            this.Controls.Add(this.VetId);
            this.Controls.Add(this.idpet);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(1500, 940);
            this.Name = "ScheduleAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleAppointment";
            this.Load += new System.EventHandler(this.ScheduleAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleAppointmentlabel;
        private System.Windows.Forms.Label idpet;
        private System.Windows.Forms.Label VetId;
        private System.Windows.Forms.Label StaffId;
        private System.Windows.Forms.Label ReasonofVisit;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox textPetId;
        private System.Windows.Forms.TextBox textVetId;
        private System.Windows.Forms.TextBox texStaffId;
        private System.Windows.Forms.TextBox textReasonofVisit;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox texTime;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DataGridView petList;
        private System.Windows.Forms.DataGridView vetList;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label staffList;
        private System.Windows.Forms.Button VetDoctor;
        private System.Windows.Forms.Button AddTreatments;
        private System.Windows.Forms.Button RegisterOwner;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.Button RegisterPet;
        private System.Windows.Forms.Button RecordBills;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffLastName;
        private System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_pet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_vet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button schedAppointment;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
    }
}