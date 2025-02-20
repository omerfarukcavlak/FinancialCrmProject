namespace FinancialCRM.UI
{
    partial class RegisterUI
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
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            btnSend = new Button();
            label5 = new Label();
            llblLogin = new LinkLabel();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(14, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(117, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(254, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.FromArgb(128, 255, 128);
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(117, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(254, 23);
            txtLastName.TabIndex = 2;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.FromArgb(128, 255, 128);
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(117, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 23);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(14, 209);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 0;
            label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(117, 206);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(254, 23);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ButtonFace;
            btnSend.Location = new Point(261, 235);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(110, 23);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(107, 9);
            label5.Name = "label5";
            label5.Size = new Size(151, 27);
            label5.TabIndex = 4;
            label5.Text = "REGISTER";
            // 
            // llblLogin
            // 
            llblLogin.AutoSize = true;
            llblLogin.LinkColor = Color.Lime;
            llblLogin.Location = new Point(225, 270);
            llblLogin.Name = "llblLogin";
            llblLogin.Size = new Size(145, 15);
            llblLogin.TabIndex = 8;
            llblLogin.TabStop = true;
            llblLogin.Text = "Already have an account? ";
            llblLogin.LinkClicked += llblLogin_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.FromArgb(128, 255, 128);
            label6.Location = new Point(14, 151);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.FromArgb(128, 255, 128);
            label7.Location = new Point(14, 180);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(117, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(254, 23);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(14, 266);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // RegisterUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(385, 302);
            Controls.Add(llblLogin);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnSend);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "RegisterUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUI";
            KeyDown += RegisterUI_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Button btnSend;
        private Label label5;
        private LinkLabel llblLogin;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPassword;
        private Button btnExit;
    }
}