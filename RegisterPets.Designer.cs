namespace PetAppointment
{
    partial class RegisterPets
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
            this.ownersList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textpetAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textpetAnimalType = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.textpetName = new System.Windows.Forms.TextBox();
            this.ScheduleAppointmentlabel = new System.Windows.Forms.Label();
            this.labelfname = new System.Windows.Forms.Label();
            this.textpetOwnerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.petsList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ownerIdSearch = new System.Windows.Forms.TextBox();
            this.textpetDescription = new System.Windows.Forms.RichTextBox();
            this.Dashboard = new System.Windows.Forms.Button();
            this.createAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTreatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ownersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Registered Pets";
            // 
            // ownersList
            // 
            this.ownersList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ownersList.BackgroundColor = System.Drawing.Color.LightPink;
            this.ownersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ownersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownersList.Location = new System.Drawing.Point(471, 555);
            this.ownersList.Name = "ownersList";
            this.ownersList.RowHeadersWidth = 51;
            this.ownersList.RowTemplate.Height = 24;
            this.ownersList.Size = new System.Drawing.Size(969, 285);
            this.ownersList.TabIndex = 38;
            this.ownersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ownersList_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Description:";
            // 
            // textpetAge
            // 
            this.textpetAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetAge.Location = new System.Drawing.Point(68, 459);
            this.textpetAge.Name = "textpetAge";
            this.textpetAge.Size = new System.Drawing.Size(299, 30);
            this.textpetAge.TabIndex = 34;
            this.textpetAge.TextChanged += new System.EventHandler(this.textpetAge_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Age:";
            // 
            // textpetAnimalType
            // 
            this.textpetAnimalType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetAnimalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetAnimalType.Location = new System.Drawing.Point(68, 388);
            this.textpetAnimalType.Name = "textpetAnimalType";
            this.textpetAnimalType.Size = new System.Drawing.Size(299, 30);
            this.textpetAnimalType.TabIndex = 32;
            this.textpetAnimalType.TextChanged += new System.EventHandler(this.textpetAnimalType_TextChanged);
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(63, 360);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(140, 25);
            this.lname.TabIndex = 31;
            this.lname.Text = "Animal Type:";
            // 
            // textpetName
            // 
            this.textpetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetName.Location = new System.Drawing.Point(68, 250);
            this.textpetName.Name = "textpetName";
            this.textpetName.Size = new System.Drawing.Size(299, 30);
            this.textpetName.TabIndex = 30;
            this.textpetName.TextChanged += new System.EventHandler(this.textpetName_TextChanged);
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(496, 50);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(458, 42);
            this.ScheduleAppointmentlabel.TabIndex = 28;
            this.ScheduleAppointmentlabel.Text = "Register Pet information";
            // 
            // labelfname
            // 
            this.labelfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(63, 222);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(113, 25);
            this.labelfname.TabIndex = 29;
            this.labelfname.Text = "Pet Name:";
            // 
            // textpetOwnerId
            // 
            this.textpetOwnerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetOwnerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetOwnerId.Location = new System.Drawing.Point(68, 313);
            this.textpetOwnerId.Name = "textpetOwnerId";
            this.textpetOwnerId.Size = new System.Drawing.Size(299, 30);
            this.textpetOwnerId.TabIndex = 41;
            this.textpetOwnerId.TextChanged += new System.EventHandler(this.textpetOwnerId_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Owner ID:";
            // 
            // petsList
            // 
            this.petsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.petsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.petsList.BackgroundColor = System.Drawing.Color.LightPink;
            this.petsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petsList.Location = new System.Drawing.Point(463, 182);
            this.petsList.Name = "petsList";
            this.petsList.RowHeadersWidth = 51;
            this.petsList.RowTemplate.Height = 24;
            this.petsList.Size = new System.Drawing.Size(977, 324);
            this.petsList.TabIndex = 42;
            this.petsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.petsList_CellContentClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Owners List";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.HotPink;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(236, 739);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 48);
            this.Delete.TabIndex = 67;
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
            this.Update.Location = new System.Drawing.Point(236, 662);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 48);
            this.Update.TabIndex = 66;
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
            this.New.Location = new System.Drawing.Point(103, 739);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 48);
            this.New.TabIndex = 65;
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
            this.Add.Location = new System.Drawing.Point(103, 662);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 64;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LightPink;
            this.Find.Location = new System.Drawing.Point(325, 156);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(85, 32);
            this.Find.TabIndex = 73;
            this.Find.Text = "Search";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Search Pet Id:";
            // 
            // ownerIdSearch
            // 
            this.ownerIdSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownerIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerIdSearch.Location = new System.Drawing.Point(68, 156);
            this.ownerIdSearch.Name = "ownerIdSearch";
            this.ownerIdSearch.Size = new System.Drawing.Size(236, 30);
            this.ownerIdSearch.TabIndex = 71;
            this.ownerIdSearch.TextChanged += new System.EventHandler(this.ownerIdSearch_TextChanged);
            // 
            // textpetDescription
            // 
            this.textpetDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetDescription.Location = new System.Drawing.Point(68, 527);
            this.textpetDescription.Name = "textpetDescription";
            this.textpetDescription.Size = new System.Drawing.Size(299, 91);
            this.textpetDescription.TabIndex = 74;
            this.textpetDescription.Text = "";
            this.textpetDescription.TextChanged += new System.EventHandler(this.textpetDescription_TextChanged);
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
            this.Dashboard.TabIndex = 75;
            this.Dashboard.Text = "Back";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
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
            this.registerPetToolStripMenuItem1.BackColor = System.Drawing.Color.HotPink;
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
            this.menuStrip1.TabIndex = 76;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegisterPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.textpetDescription);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ownerIdSearch);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.petsList);
            this.Controls.Add(this.textpetOwnerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ownersList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpetAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpetAnimalType);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.textpetName);
            this.Controls.Add(this.ScheduleAppointmentlabel);
            this.Controls.Add(this.labelfname);
            this.MaximumSize = new System.Drawing.Size(1500, 940);
            this.Name = "RegisterPets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPets";
            this.Load += new System.EventHandler(this.RegisterPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ownersList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpetAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpetAnimalType;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox textpetName;
        private System.Windows.Forms.Label ScheduleAppointmentlabel;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.TextBox textpetOwnerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView petsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ownerIdSearch;
        private System.Windows.Forms.RichTextBox textpetDescription;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.ToolStripMenuItem createAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerNewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTreatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStaffToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}