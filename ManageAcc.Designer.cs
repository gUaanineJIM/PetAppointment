namespace PetAppointment
{
    partial class ManageAcc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFavPet = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.vetearningBtn = new System.Windows.Forms.Button();
            this.textVETID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.backupTablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 31);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.addAccountToolStripMenuItem.Text = "Dashboard";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // backupTablesToolStripMenuItem
            // 
            this.backupTablesToolStripMenuItem.Name = "backupTablesToolStripMenuItem";
            this.backupTablesToolStripMenuItem.Size = new System.Drawing.Size(168, 27);
            this.backupTablesToolStripMenuItem.Text = "Backup All Records";
            // 
            // textFavPet
            // 
            this.textFavPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textFavPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFavPet.Location = new System.Drawing.Point(121, 549);
            this.textFavPet.Name = "textFavPet";
            this.textFavPet.Size = new System.Drawing.Size(205, 30);
            this.textFavPet.TabIndex = 25;
            this.textFavPet.TextChanged += new System.EventHandler(this.textFavPet_TextChanged);
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmPassword.Location = new System.Drawing.Point(120, 465);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(205, 30);
            this.textConfirmPassword.TabIndex = 24;
            this.textConfirmPassword.TextChanged += new System.EventHandler(this.textConfirmPassword_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(119, 382);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(205, 30);
            this.textPassword.TabIndex = 23;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textUsername
            // 
            this.textUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(119, 304);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(205, 30);
            this.textUsername.TabIndex = 22;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name of users first pet?\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username:";
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(119, 222);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(205, 30);
            this.textName.TabIndex = 17;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.LightGreen;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(237, 687);
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
            this.Update.BackColor = System.Drawing.Color.LightGreen;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(237, 612);
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
            this.New.BackColor = System.Drawing.Color.LightGreen;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(104, 687);
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
            this.Add.BackColor = System.Drawing.Color.LightGreen;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(104, 612);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 48);
            this.Add.TabIndex = 64;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToDeleteRows = false;
            this.UsersTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTable.BackgroundColor = System.Drawing.Color.LightPink;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Location = new System.Drawing.Point(450, 270);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            this.UsersTable.RowHeadersWidth = 51;
            this.UsersTable.RowTemplate.Height = 24;
            this.UsersTable.Size = new System.Drawing.Size(899, 465);
            this.UsersTable.TabIndex = 68;
            this.UsersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTable_CellClick);
            this.UsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTable_CellClick);
            // 
            // vetearningBtn
            // 
            this.vetearningBtn.BackColor = System.Drawing.Color.LightGreen;
            this.vetearningBtn.FlatAppearance.BorderSize = 0;
            this.vetearningBtn.Location = new System.Drawing.Point(357, 129);
            this.vetearningBtn.Name = "vetearningBtn";
            this.vetearningBtn.Size = new System.Drawing.Size(85, 32);
            this.vetearningBtn.TabIndex = 82;
            this.vetearningBtn.Text = "Search";
            this.vetearningBtn.UseVisualStyleBackColor = false;
            // 
            // textVETID
            // 
            this.textVETID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textVETID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVETID.Location = new System.Drawing.Point(119, 129);
            this.textVETID.Name = "textVETID";
            this.textVETID.Size = new System.Drawing.Size(236, 30);
            this.textVETID.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Enter ID to find Account:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Users table:";
            // 
            // ManageAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 893);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vetearningBtn);
            this.Controls.Add(this.textVETID);
            this.Controls.Add(this.UsersTable);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textFavPet);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1500, 940);
            this.MinimumSize = new System.Drawing.Size(1500, 940);
            this.Name = "ManageAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAcc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupTablesToolStripMenuItem;
        private System.Windows.Forms.TextBox textFavPet;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.Button vetearningBtn;
        private System.Windows.Forms.TextBox textVETID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}