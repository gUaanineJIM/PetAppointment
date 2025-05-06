namespace PetAppointment
{
    partial class RecoverAcc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textRecoveryPin = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Verify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PetAppointment.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(63, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textRecoveryPin
            // 
            this.textRecoveryPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRecoveryPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRecoveryPin.Location = new System.Drawing.Point(476, 271);
            this.textRecoveryPin.Name = "textRecoveryPin";
            this.textRecoveryPin.Size = new System.Drawing.Size(300, 30);
            this.textRecoveryPin.TabIndex = 18;
            this.textRecoveryPin.TextChanged += new System.EventHandler(this.textRecoveryPin_TextChanged);
            // 
            // textUsername
            // 
            this.textUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(476, 155);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(300, 30);
            this.textUsername.TabIndex = 17;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name of your first pet?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username:";
            // 
            // Verify
            // 
            this.Verify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Verify.BackColor = System.Drawing.Color.LightGreen;
            this.Verify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify.Location = new System.Drawing.Point(524, 366);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(219, 47);
            this.Verify.TabIndex = 26;
            this.Verify.Text = "Verify";
            this.Verify.UseVisualStyleBackColor = false;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Let\'s Verify Your Account.";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(637, 324);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(139, 20);
            this.login.TabIndex = 28;
            this.login.TabStop = true;
            this.login.Text = "Login Account?";
            this.login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_LinkClicked);
            // 
            // RecoverAcc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(998, 577);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.textRecoveryPin);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1016, 624);
            this.MinimumSize = new System.Drawing.Size(1016, 624);
            this.Name = "RecoverAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverAcc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textRecoveryPin;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel login;
    }
}