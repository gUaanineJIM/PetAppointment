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
            this.label4 = new System.Windows.Forms.Label();
            this.textBillStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.textbillAppointmentId = new System.Windows.Forms.TextBox();
            this.labelfname = new System.Windows.Forms.Label();
            this.ScheduleAppointmentlabel = new System.Windows.Forms.Label();
            this.billsList = new System.Windows.Forms.DataGridView();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.treatmentList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.staffIdSearch = new System.Windows.Forms.TextBox();
            this.Dashboard = new System.Windows.Forms.Button();
            this.paidbtn = new System.Windows.Forms.Button();
            this.unpaidbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTreatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.billsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Bills Record";
            // 
            // textBillStatus
            // 
            this.textBillStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBillStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBillStatus.Location = new System.Drawing.Point(87, 512);
            this.textBillStatus.MaxLength = 11;
            this.textBillStatus.Name = "textBillStatus";
            this.textBillStatus.Size = new System.Drawing.Size(299, 30);
            this.textBillStatus.TabIndex = 75;
            this.textBillStatus.TextChanged += new System.EventHandler(this.textBillStatus_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 484);
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
            this.lname.Location = new System.Drawing.Point(79, 396);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(236, 25);
            this.lname.TabIndex = 72;
            this.lname.Text = "Total Cost (to be paid):";
            // 
            // textbillAppointmentId
            // 
            this.textbillAppointmentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbillAppointmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbillAppointmentId.Location = new System.Drawing.Point(84, 336);
            this.textbillAppointmentId.Name = "textbillAppointmentId";
            this.textbillAppointmentId.Size = new System.Drawing.Size(299, 30);
            this.textbillAppointmentId.TabIndex = 71;
            this.textbillAppointmentId.TextChanged += new System.EventHandler(this.textbillAppointmentId_TextChanged);
            // 
            // labelfname
            // 
            this.labelfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(79, 308);
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
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(627, 50);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(229, 42);
            this.ScheduleAppointmentlabel.TabIndex = 69;
            this.ScheduleAppointmentlabel.Text = "Record Bills";
            // 
            // billsList
            // 
            this.billsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.billsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billsList.BackgroundColor = System.Drawing.Color.LightPink;
            this.billsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.billsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsList.Location = new System.Drawing.Point(540, 147);
            this.billsList.Name = "billsList";
            this.billsList.RowHeadersWidth = 51;
            this.billsList.RowTemplate.Height = 24;
            this.billsList.Size = new System.Drawing.Size(874, 332);
            this.billsList.TabIndex = 76;
            this.billsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsList_CellClick);
            // 
            // textTotalCost
            // 
            this.textTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalCost.Location = new System.Drawing.Point(84, 424);
            this.textTotalCost.Name = "textTotalCost";
            this.textTotalCost.Size = new System.Drawing.Size(299, 30);
            this.textTotalCost.TabIndex = 73;
            this.textTotalCost.TextChanged += new System.EventHandler(this.textTotalCost_TextChanged);
            // 
            // treatmentList
            // 
            this.treatmentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treatmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.treatmentList.BackgroundColor = System.Drawing.Color.LightPink;
            this.treatmentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.treatmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentList.Location = new System.Drawing.Point(540, 532);
            this.treatmentList.Name = "treatmentList";
            this.treatmentList.RowHeadersWidth = 51;
            this.treatmentList.RowTemplate.Height = 24;
            this.treatmentList.Size = new System.Drawing.Size(874, 305);
            this.treatmentList.TabIndex = 83;
            this.treatmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.treatmentList_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Treatment with no Bills issued";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.HotPink;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(246, 708);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 48);
            this.Delete.TabIndex = 87;
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
            this.Update.Location = new System.Drawing.Point(246, 631);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 48);
            this.Update.TabIndex = 86;
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
            this.New.Location = new System.Drawing.Point(113, 708);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 48);
            this.New.TabIndex = 85;
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
            this.Add.Location = new System.Drawing.Point(113, 631);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 84;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LightPink;
            this.Find.Location = new System.Drawing.Point(325, 175);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(85, 32);
            this.Find.TabIndex = 90;
            this.Find.Text = "Search";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Search bill Id:";
            // 
            // staffIdSearch
            // 
            this.staffIdSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdSearch.Location = new System.Drawing.Point(83, 177);
            this.staffIdSearch.Name = "staffIdSearch";
            this.staffIdSearch.Size = new System.Drawing.Size(236, 30);
            this.staffIdSearch.TabIndex = 88;
            this.staffIdSearch.TextChanged += new System.EventHandler(this.staffIdSearch_TextChanged);
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
            this.Dashboard.TabIndex = 91;
            this.Dashboard.Text = "Back";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // paidbtn
            // 
            this.paidbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paidbtn.BackColor = System.Drawing.Color.LightGreen;
            this.paidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paidbtn.Location = new System.Drawing.Point(87, 548);
            this.paidbtn.Name = "paidbtn";
            this.paidbtn.Size = new System.Drawing.Size(137, 40);
            this.paidbtn.TabIndex = 92;
            this.paidbtn.Text = "Paid";
            this.paidbtn.UseVisualStyleBackColor = false;
            this.paidbtn.Click += new System.EventHandler(this.paidbtn_Click);
            // 
            // unpaidbtn
            // 
            this.unpaidbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unpaidbtn.BackColor = System.Drawing.Color.Crimson;
            this.unpaidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpaidbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unpaidbtn.Location = new System.Drawing.Point(246, 548);
            this.unpaidbtn.Name = "unpaidbtn";
            this.unpaidbtn.Size = new System.Drawing.Size(137, 40);
            this.unpaidbtn.TabIndex = 93;
            this.unpaidbtn.Text = "Unpaid";
            this.unpaidbtn.UseVisualStyleBackColor = false;
            this.unpaidbtn.Click += new System.EventHandler(this.unpaidbtn_Click);
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
            this.menuStrip1.TabIndex = 94;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createAppointmentToolStripMenuItem
            // 
            this.createAppointmentToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
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
            this.recordBillsToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
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
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.unpaidbtn);
            this.Controls.Add(this.paidbtn);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.staffIdSearch);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.treatmentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBillStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.textbillAppointmentId);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.Controls.Add(this.billsList);
            this.Controls.Add(this.textTotalCost);
            this.MinimumSize = new System.Drawing.Size(1500, 940);
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBillStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox textbillAppointmentId;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label ScheduleAppointmentlabel;
        private System.Windows.Forms.DataGridView billsList;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.DataGridView treatmentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox staffIdSearch;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button paidbtn;
        private System.Windows.Forms.Button unpaidbtn;
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