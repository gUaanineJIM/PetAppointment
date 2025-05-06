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
            this.vetLists = new System.Windows.Forms.DataGridView();
            this.textspecialization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textvetLname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.textvetFname = new System.Windows.Forms.TextBox();
            this.ScheduleAppointmentlabel = new System.Windows.Forms.Label();
            this.labelfname = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vetIdSearch = new System.Windows.Forms.TextBox();
            this.Dashboard = new System.Windows.Forms.Button();
            this.vetearningBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textVETID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTreatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vetLists)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Registered Vet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // vetLists
            // 
            this.vetLists.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vetLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vetLists.BackgroundColor = System.Drawing.Color.LightPink;
            this.vetLists.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vetLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetLists.Location = new System.Drawing.Point(501, 314);
            this.vetLists.Name = "vetLists";
            this.vetLists.RowHeadersWidth = 51;
            this.vetLists.RowTemplate.Height = 24;
            this.vetLists.Size = new System.Drawing.Size(931, 430);
            this.vetLists.TabIndex = 38;
            this.vetLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vetLists_CellContentClick);
            // 
            // textspecialization
            // 
            this.textspecialization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textspecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textspecialization.Location = new System.Drawing.Point(82, 555);
            this.textspecialization.MaxLength = 50;
            this.textspecialization.Name = "textspecialization";
            this.textspecialization.Size = new System.Drawing.Size(299, 30);
            this.textspecialization.TabIndex = 36;
            this.textspecialization.TextChanged += new System.EventHandler(this.textspecialization_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Specialization:";
            // 
            // textphone
            // 
            this.textphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textphone.Location = new System.Drawing.Point(82, 467);
            this.textphone.MaxLength = 11;
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(299, 30);
            this.textphone.TabIndex = 34;
            this.textphone.TextChanged += new System.EventHandler(this.textphone_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Phone:";
            // 
            // textvetLname
            // 
            this.textvetLname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textvetLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvetLname.Location = new System.Drawing.Point(82, 379);
            this.textvetLname.Name = "textvetLname";
            this.textvetLname.Size = new System.Drawing.Size(299, 30);
            this.textvetLname.TabIndex = 32;
            this.textvetLname.TextChanged += new System.EventHandler(this.textvetLname_TextChanged);
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(77, 351);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(122, 25);
            this.lname.TabIndex = 31;
            this.lname.Text = "Last Name:";
            // 
            // textvetFname
            // 
            this.textvetFname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textvetFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvetFname.Location = new System.Drawing.Point(82, 291);
            this.textvetFname.Name = "textvetFname";
            this.textvetFname.Size = new System.Drawing.Size(299, 30);
            this.textvetFname.TabIndex = 30;
            this.textvetFname.TextChanged += new System.EventHandler(this.textvetFname_TextChanged);
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(494, 50);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(459, 42);
            this.ScheduleAppointmentlabel.TabIndex = 28;
            this.ScheduleAppointmentlabel.Text = "Register Vet information";
            // 
            // labelfname
            // 
            this.labelfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(77, 263);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(123, 25);
            this.labelfname.TabIndex = 29;
            this.labelfname.Text = "First Name:";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.HotPink;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(244, 705);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 48);
            this.Delete.TabIndex = 71;
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
            this.Update.Location = new System.Drawing.Point(244, 628);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 48);
            this.Update.TabIndex = 70;
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
            this.New.Location = new System.Drawing.Point(111, 705);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 48);
            this.New.TabIndex = 69;
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
            this.Add.Location = new System.Drawing.Point(111, 628);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 68;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LightPink;
            this.Find.Location = new System.Drawing.Point(341, 161);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(85, 32);
            this.Find.TabIndex = 76;
            this.Find.Text = "Search";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Search Vet Id:";
            // 
            // vetIdSearch
            // 
            this.vetIdSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vetIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vetIdSearch.Location = new System.Drawing.Point(82, 159);
            this.vetIdSearch.Name = "vetIdSearch";
            this.vetIdSearch.Size = new System.Drawing.Size(236, 30);
            this.vetIdSearch.TabIndex = 74;
            this.vetIdSearch.TextChanged += new System.EventHandler(this.vetIdSearch_TextChanged);
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
            this.Dashboard.TabIndex = 77;
            this.Dashboard.Text = "Back";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // vetearningBtn
            // 
            this.vetearningBtn.BackColor = System.Drawing.Color.LightGreen;
            this.vetearningBtn.FlatAppearance.BorderSize = 0;
            this.vetearningBtn.Location = new System.Drawing.Point(1347, 173);
            this.vetearningBtn.Name = "vetearningBtn";
            this.vetearningBtn.Size = new System.Drawing.Size(85, 32);
            this.vetearningBtn.TabIndex = 80;
            this.vetearningBtn.Text = "Search";
            this.vetearningBtn.UseVisualStyleBackColor = false;
            this.vetearningBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1104, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Enter ID to compute total earnings:\r\n";
            // 
            // textVETID
            // 
            this.textVETID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textVETID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVETID.Location = new System.Drawing.Point(1109, 173);
            this.textVETID.Name = "textVETID";
            this.textVETID.Size = new System.Drawing.Size(236, 30);
            this.textVETID.TabIndex = 78;
            this.textVETID.TextChanged += new System.EventHandler(this.textVETID_TextChanged);
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
            this.menuStrip1.TabIndex = 81;
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
            this.registerNewDoctorToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
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
            // Vet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vetearningBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textVETID);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vetIdSearch);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vetLists);
            this.Controls.Add(this.textspecialization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvetLname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.textvetFname);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.Controls.Add(this.labelfname);
            this.MaximumSize = new System.Drawing.Size(1500, 940);
            this.Name = "Vet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vet";
            this.Load += new System.EventHandler(this.Vet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetLists)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView vetLists;
        private System.Windows.Forms.TextBox textspecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textvetLname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox textvetFname;
        private System.Windows.Forms.Label ScheduleAppointmentlabel;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vetIdSearch;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button vetearningBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textVETID;
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