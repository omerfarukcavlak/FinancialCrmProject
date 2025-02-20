namespace FinancialCRM.UI
{
    partial class LoginUI
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
            llblRegister = new LinkLabel();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.LinkColor = Color.Lime;
            llblRegister.Location = new Point(237, 176);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(131, 15);
            llblRegister.TabIndex = 4;
            llblRegister.TabStop = true;
            llblRegister.Text = "Don't have an account?";
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(142, 9);
            label5.Name = "label5";
            label5.Size = new Size(100, 27);
            label5.TabIndex = 12;
            label5.Text = "LOGIN";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 101);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(254, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(11, 104);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.FromArgb(128, 255, 128);
            label3.Location = new Point(11, 75);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(258, 139);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 172);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(383, 214);
            Controls.Add(llblRegister);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "LoginUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUI";
            KeyDown += LoginUI_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llblRegister;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private Button btnLogin;
        private Button btnExit;
    }
}