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
            this.textDate = new System.Windows.Forms.TextBox();
            this.texTime = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.petLists = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.VetListBTN = new System.Windows.Forms.Button();
            this.StaffListBTN = new System.Windows.Forms.Button();
            this.textReasonofVisit = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.historyBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTreatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.petLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(580, 49);
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
            this.idpet.Location = new System.Drawing.Point(47, 106);
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
            this.VetId.Location = new System.Drawing.Point(47, 209);
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
            this.StaffId.Location = new System.Drawing.Point(266, 106);
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
            this.ReasonofVisit.Location = new System.Drawing.Point(257, 167);
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
            this.date.Location = new System.Drawing.Point(602, 187);
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
            this.textPetId.Location = new System.Drawing.Point(51, 139);
            this.textPetId.Name = "textPetId";
            this.textPetId.Size = new System.Drawing.Size(159, 30);
            this.textPetId.TabIndex = 6;
            this.textPetId.TextChanged += new System.EventHandler(this.textPetId_TextChanged);
            // 
            // textVetId
            // 
            this.textVetId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textVetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVetId.Location = new System.Drawing.Point(52, 237);
            this.textVetId.Name = "textVetId";
            this.textVetId.Size = new System.Drawing.Size(159, 30);
            this.textVetId.TabIndex = 7;
            this.textVetId.TextChanged += new System.EventHandler(this.textVetId_TextChanged);
            // 
            // texStaffId
            // 
            this.texStaffId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texStaffId.Location = new System.Drawing.Point(262, 134);
            this.texStaffId.Name = "texStaffId";
            this.texStaffId.Size = new System.Drawing.Size(159, 30);
            this.texStaffId.TabIndex = 8;
            this.texStaffId.TextChanged += new System.EventHandler(this.texStaffId_TextChanged);
            // 
            // textDate
            // 
            this.textDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(672, 187);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(235, 30);
            this.textDate.TabIndex = 10;
            this.textDate.TextChanged += new System.EventHandler(this.textDate_TextChanged);
            // 
            // texTime
            // 
            this.texTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTime.Location = new System.Drawing.Point(672, 237);
            this.texTime.Name = "texTime";
            this.texTime.Size = new System.Drawing.Size(235, 30);
            this.texTime.TabIndex = 12;
            this.texTime.TextChanged += new System.EventHandler(this.texTime_TextChanged);
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(599, 240);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(67, 25);
            this.Time.TabIndex = 11;
            this.Time.Text = "Time:";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // petLists
            // 
            this.petLists.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.petLists.BackgroundColor = System.Drawing.Color.White;
            this.petLists.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petLists.Location = new System.Drawing.Point(25, 374);
            this.petLists.Name = "petLists";
            this.petLists.RowHeadersWidth = 25;
            this.petLists.RowTemplate.Height = 24;
            this.petLists.Size = new System.Drawing.Size(517, 465);
            this.petLists.TabIndex = 17;
            this.petLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pet List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // appointmentList
            // 
            this.appointmentList.AllowUserToDeleteRows = false;
            this.appointmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentList.BackgroundColor = System.Drawing.Color.White;
            this.appointmentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.Location = new System.Drawing.Point(548, 374);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.ReadOnly = true;
            this.appointmentList.RowHeadersWidth = 51;
            this.appointmentList.RowTemplate.Height = 24;
            this.appointmentList.Size = new System.Drawing.Size(920, 465);
            this.appointmentList.TabIndex = 23;
            this.appointmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentList_CellClick);
            this.appointmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentList_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 346);
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
            this.Delete.Location = new System.Drawing.Point(1113, 219);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 48);
            this.Delete.TabIndex = 63;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.HotPink;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(1113, 144);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 48);
            this.Update.TabIndex = 62;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // New
            // 
            this.New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New.BackColor = System.Drawing.Color.HotPink;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(976, 217);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 48);
            this.New.TabIndex = 61;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.HotPink;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(976, 144);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 60;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dashboard.BackColor = System.Drawing.Color.LightPink;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(20, 50);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(119, 35);
            this.Dashboard.TabIndex = 16;
            this.Dashboard.Text = "Back";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // VetListBTN
            // 
            this.VetListBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VetListBTN.BackColor = System.Drawing.Color.LightGreen;
            this.VetListBTN.FlatAppearance.BorderSize = 0;
            this.VetListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VetListBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetListBTN.Location = new System.Drawing.Point(1292, 61);
            this.VetListBTN.Name = "VetListBTN";
            this.VetListBTN.Size = new System.Drawing.Size(174, 48);
            this.VetListBTN.TabIndex = 64;
            this.VetListBTN.Text = "View Doctors";
            this.VetListBTN.UseVisualStyleBackColor = false;
            this.VetListBTN.Click += new System.EventHandler(this.VetListBTN_Click);
            // 
            // StaffListBTN
            // 
            this.StaffListBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffListBTN.BackColor = System.Drawing.Color.LightGreen;
            this.StaffListBTN.FlatAppearance.BorderSize = 0;
            this.StaffListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffListBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffListBTN.Location = new System.Drawing.Point(1292, 124);
            this.StaffListBTN.Name = "StaffListBTN";
            this.StaffListBTN.Size = new System.Drawing.Size(174, 48);
            this.StaffListBTN.TabIndex = 65;
            this.StaffListBTN.Text = "View Staffs";
            this.StaffListBTN.UseVisualStyleBackColor = false;
            this.StaffListBTN.Click += new System.EventHandler(this.StaffListBTN_Click);
            // 
            // textReasonofVisit
            // 
            this.textReasonofVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReasonofVisit.Location = new System.Drawing.Point(262, 197);
            this.textReasonofVisit.Name = "textReasonofVisit";
            this.textReasonofVisit.Size = new System.Drawing.Size(299, 116);
            this.textReasonofVisit.TabIndex = 66;
            this.textReasonofVisit.Text = "";
            this.textReasonofVisit.TextChanged += new System.EventHandler(this.textReasonofVisit_TextChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 132);
            this.dateTimePicker1.MaxDate = new System.DateTime(2109, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(341, 30);
            this.dateTimePicker1.TabIndex = 67;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // historyBTN
            // 
            this.historyBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.historyBTN.BackColor = System.Drawing.Color.LightGreen;
            this.historyBTN.FlatAppearance.BorderSize = 0;
            this.historyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBTN.Location = new System.Drawing.Point(1292, 187);
            this.historyBTN.Name = "historyBTN";
            this.historyBTN.Size = new System.Drawing.Size(174, 48);
            this.historyBTN.TabIndex = 68;
            this.historyBTN.Text = "History\r\n";
            this.historyBTN.UseVisualStyleBackColor = false;
            this.historyBTN.Click += new System.EventHandler(this.historyBTN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAppointmentToolStripMenuItem,
            this.registerPetToolStripMenuItem,
            this.registerPetToolStripMenuItem1,
            this.registerNewDoctorToolStripMenuItem,
            this.createTreatmentToolStripMenuItem,
            this.recordBillsToolStripMenuItem,
            this.registerStaffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 31);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createAppointmentToolStripMenuItem
            // 
            this.createAppointmentToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.createAppointmentToolStripMenuItem.Name = "createAppointmentToolStripMenuItem";
            this.createAppointmentToolStripMenuItem.Size = new System.Drawing.Size(189, 27);
            this.createAppointmentToolStripMenuItem.Text = "Create Appointment";
            this.createAppointmentToolStripMenuItem.Click += new System.EventHandler(this.createAppointmentToolStripMenuItem_Click);
            // 
            // registerPetToolStripMenuItem
            // 
            this.registerPetToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.registerPetToolStripMenuItem.Name = "registerPetToolStripMenuItem";
            this.registerPetToolStripMenuItem.Size = new System.Drawing.Size(148, 27);
            this.registerPetToolStripMenuItem.Text = "Register Owner";
            this.registerPetToolStripMenuItem.Click += new System.EventHandler(this.registerPetToolStripMenuItem_Click);
            // 
            // registerPetToolStripMenuItem1
            // 
            this.registerPetToolStripMenuItem1.BackColor = System.Drawing.Color.LavenderBlush;
            this.registerPetToolStripMenuItem1.Name = "registerPetToolStripMenuItem1";
            this.registerPetToolStripMenuItem1.Size = new System.Drawing.Size(120, 27);
            this.registerPetToolStripMenuItem1.Text = "Register Pet";
            this.registerPetToolStripMenuItem1.Click += new System.EventHandler(this.registerPetToolStripMenuItem1_Click);
            // 
            // registerNewDoctorToolStripMenuItem
            // 
            this.registerNewDoctorToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.registerNewDoctorToolStripMenuItem.Name = "registerNewDoctorToolStripMenuItem";
            this.registerNewDoctorToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.registerNewDoctorToolStripMenuItem.Text = "Register Doctor";
            this.registerNewDoctorToolStripMenuItem.Click += new System.EventHandler(this.registerNewDoctorToolStripMenuItem_Click);
            // 
            // createTreatmentToolStripMenuItem
            // 
            this.createTreatmentToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.createTreatmentToolStripMenuItem.Name = "createTreatmentToolStripMenuItem";
            this.createTreatmentToolStripMenuItem.Size = new System.Drawing.Size(164, 27);
            this.createTreatmentToolStripMenuItem.Text = "Create Treatment";
            this.createTreatmentToolStripMenuItem.Click += new System.EventHandler(this.createTreatmentToolStripMenuItem_Click);
            // 
            // recordBillsToolStripMenuItem
            // 
            this.recordBillsToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.recordBillsToolStripMenuItem.Name = "recordBillsToolStripMenuItem";
            this.recordBillsToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.recordBillsToolStripMenuItem.Text = "Record Bills";
            this.recordBillsToolStripMenuItem.Click += new System.EventHandler(this.recordBillsToolStripMenuItem_Click);
            // 
            // registerStaffToolStripMenuItem
            // 
            this.registerStaffToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.registerStaffToolStripMenuItem.Name = "registerStaffToolStripMenuItem";
            this.registerStaffToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.registerStaffToolStripMenuItem.Text = "Register Staff";
            this.registerStaffToolStripMenuItem.Click += new System.EventHandler(this.registerStaffToolStripMenuItem_Click);
            // 
            // ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.historyBTN);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textReasonofVisit);
            this.Controls.Add(this.StaffListBTN);
            this.Controls.Add(this.VetListBTN);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petLists);
            this.Controls.Add(this.texTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.texStaffId);
            this.Controls.Add(this.textVetId);
            this.Controls.Add(this.textPetId);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ReasonofVisit);
            this.Controls.Add(this.StaffId);
            this.Controls.Add(this.VetId);
            this.Controls.Add(this.idpet);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(1500, 940);
            this.Name = "ScheduleAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleAppointment";
            this.Load += new System.EventHandler(this.ScheduleAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox texTime;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DataGridView petLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button VetListBTN;
        private System.Windows.Forms.Button StaffListBTN;
        private System.Windows.Forms.RichTextBox textReasonofVisit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button historyBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerNewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTreatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStaffToolStripMenuItem;
    }
}