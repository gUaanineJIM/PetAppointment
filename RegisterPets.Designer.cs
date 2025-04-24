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
            this.owner_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownersList = new System.Windows.Forms.DataGridView();
            this.owner_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textpetAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textpetAnimalType = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.textpetName = new System.Windows.Forms.TextBox();
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
            this.textpetOwnerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.petsList = new System.Windows.Forms.DataGridView();
            this.pet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petOwner_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ownerIdSearch = new System.Windows.Forms.TextBox();
            this.textpetDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ownersList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(947, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Registered Pets";
            // 
            // owner_phone
            // 
            this.owner_phone.HeaderText = "Phone";
            this.owner_phone.MinimumWidth = 6;
            this.owner_phone.Name = "owner_phone";
            this.owner_phone.Width = 125;
            // 
            // owner_last_name
            // 
            this.owner_last_name.HeaderText = "Last Name";
            this.owner_last_name.MinimumWidth = 6;
            this.owner_last_name.Name = "owner_last_name";
            this.owner_last_name.Width = 125;
            // 
            // owner_first_name
            // 
            this.owner_first_name.HeaderText = "First Name";
            this.owner_first_name.MinimumWidth = 6;
            this.owner_first_name.Name = "owner_first_name";
            this.owner_first_name.Width = 125;
            // 
            // owner_id
            // 
            this.owner_id.HeaderText = "Owner Id";
            this.owner_id.MinimumWidth = 6;
            this.owner_id.Name = "owner_id";
            this.owner_id.Width = 125;
            // 
            // ownersList
            // 
            this.ownersList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownersList.BackgroundColor = System.Drawing.Color.LightPink;
            this.ownersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ownersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owner_id,
            this.owner_first_name,
            this.owner_last_name,
            this.owner_phone,
            this.owner_address});
            this.ownersList.Location = new System.Drawing.Point(597, 555);
            this.ownersList.Name = "ownersList";
            this.ownersList.RowHeadersWidth = 51;
            this.ownersList.RowTemplate.Height = 24;
            this.ownersList.Size = new System.Drawing.Size(860, 285);
            this.ownersList.TabIndex = 38;
            // 
            // owner_address
            // 
            this.owner_address.HeaderText = "Address";
            this.owner_address.MinimumWidth = 6;
            this.owner_address.Name = "owner_address";
            this.owner_address.Width = 125;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Description:";
            // 
            // textpetAge
            // 
            this.textpetAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetAge.Location = new System.Drawing.Point(230, 507);
            this.textpetAge.Name = "textpetAge";
            this.textpetAge.Size = new System.Drawing.Size(299, 30);
            this.textpetAge.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Age:";
            // 
            // textpetAnimalType
            // 
            this.textpetAnimalType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetAnimalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetAnimalType.Location = new System.Drawing.Point(230, 436);
            this.textpetAnimalType.Name = "textpetAnimalType";
            this.textpetAnimalType.Size = new System.Drawing.Size(299, 30);
            this.textpetAnimalType.TabIndex = 32;
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(225, 408);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(140, 25);
            this.lname.TabIndex = 31;
            this.lname.Text = "Animal Type:";
            // 
            // textpetName
            // 
            this.textpetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetName.Location = new System.Drawing.Point(230, 298);
            this.textpetName.Name = "textpetName";
            this.textpetName.Size = new System.Drawing.Size(299, 30);
            this.textpetName.TabIndex = 30;
            // 
            // ScheduleAppointmentlabel
            // 
            this.ScheduleAppointmentlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleAppointmentlabel.AutoSize = true;
            this.ScheduleAppointmentlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentlabel.Location = new System.Drawing.Point(590, 43);
            this.ScheduleAppointmentlabel.Name = "ScheduleAppointmentlabel";
            this.ScheduleAppointmentlabel.Size = new System.Drawing.Size(458, 42);
            this.ScheduleAppointmentlabel.TabIndex = 28;
            this.ScheduleAppointmentlabel.Text = "Register Pet information";
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
            // schedAppointment
            // 
            this.schedAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schedAppointment.BackColor = System.Drawing.Color.Transparent;
            this.schedAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schedAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // RegisterPet
            // 
            this.RegisterPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPet.BackColor = System.Drawing.Color.HotPink;
            this.RegisterPet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPet.Location = new System.Drawing.Point(17, 372);
            this.RegisterPet.Name = "RegisterPet";
            this.RegisterPet.Size = new System.Drawing.Size(150, 35);
            this.RegisterPet.TabIndex = 9;
            this.RegisterPet.Text = "Register Pet";
            this.RegisterPet.UseVisualStyleBackColor = false;
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
            // labelfname
            // 
            this.labelfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(225, 270);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(113, 25);
            this.labelfname.TabIndex = 29;
            this.labelfname.Text = "Pet Name:";
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
            this.panel1.TabIndex = 27;
            // 
            // textpetOwnerId
            // 
            this.textpetOwnerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetOwnerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpetOwnerId.Location = new System.Drawing.Point(230, 361);
            this.textpetOwnerId.Name = "textpetOwnerId";
            this.textpetOwnerId.Size = new System.Drawing.Size(299, 30);
            this.textpetOwnerId.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Owner ID:";
            // 
            // petsList
            // 
            this.petsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.petsList.BackgroundColor = System.Drawing.Color.LightPink;
            this.petsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pet_id,
            this.petOwner_id,
            this.animal_type,
            this.age,
            this.description});
            this.petsList.Location = new System.Drawing.Point(597, 182);
            this.petsList.Name = "petsList";
            this.petsList.RowHeadersWidth = 51;
            this.petsList.RowTemplate.Height = 24;
            this.petsList.Size = new System.Drawing.Size(860, 324);
            this.petsList.TabIndex = 42;
            // 
            // pet_id
            // 
            this.pet_id.HeaderText = "Pet Id";
            this.pet_id.MinimumWidth = 6;
            this.pet_id.Name = "pet_id";
            this.pet_id.Width = 125;
            // 
            // petOwner_id
            // 
            this.petOwner_id.HeaderText = "Owner Id";
            this.petOwner_id.MinimumWidth = 6;
            this.petOwner_id.Name = "petOwner_id";
            this.petOwner_id.Width = 125;
            // 
            // animal_type
            // 
            this.animal_type.HeaderText = "Animal Type";
            this.animal_type.MinimumWidth = 6;
            this.animal_type.Name = "animal_type";
            this.animal_type.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(947, 527);
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
            this.Delete.Location = new System.Drawing.Point(407, 773);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 48);
            this.Delete.TabIndex = 67;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.HotPink;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(407, 696);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 48);
            this.Update.TabIndex = 66;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // New
            // 
            this.New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New.BackColor = System.Drawing.Color.HotPink;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(274, 773);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 48);
            this.New.TabIndex = 65;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.HotPink;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(274, 696);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 64;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LightPink;
            this.Find.Location = new System.Drawing.Point(472, 189);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(85, 32);
            this.Find.TabIndex = 73;
            this.Find.Text = "Search";
            this.Find.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Search Pet Id:";
            // 
            // ownerIdSearch
            // 
            this.ownerIdSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownerIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerIdSearch.Location = new System.Drawing.Point(230, 191);
            this.ownerIdSearch.Name = "ownerIdSearch";
            this.ownerIdSearch.Size = new System.Drawing.Size(236, 30);
            this.ownerIdSearch.TabIndex = 71;
            // 
            // textpetDescription
            // 
            this.textpetDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpetDescription.Location = new System.Drawing.Point(230, 575);
            this.textpetDescription.Name = "textpetDescription";
            this.textpetDescription.Size = new System.Drawing.Size(299, 91);
            this.textpetDescription.TabIndex = 74;
            this.textpetDescription.Text = "";
            // 
            // RegisterPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 893);
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
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1500, 940);
            this.Name = "RegisterPets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPets";
            this.Load += new System.EventHandler(this.RegisterPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownersList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_id;
        private System.Windows.Forms.DataGridView ownersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpetAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpetAnimalType;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox textpetName;
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
        private System.Windows.Forms.TextBox textpetOwnerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView petsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn petOwner_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ownerIdSearch;
        private System.Windows.Forms.RichTextBox textpetDescription;
    }
}