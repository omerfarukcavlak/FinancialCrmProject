namespace FinancialCRM.UI
{
    partial class FrmSettings
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
            panel1 = new Panel();
            btnLogOut = new Button();
            btnDashboard = new Button();
            btnSettings = new Button();
            btnBankProcess = new Button();
            btnSpendings = new Button();
            btnBills = new Button();
            btnCategories = new Button();
            btnBanks = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 84, 128);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnBankProcess);
            panel1.Controls.Add(btnSpendings);
            panel1.Controls.Add(btnBills);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnBanks);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 356);
            panel1.TabIndex = 6;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(11, 84, 128);
            btnLogOut.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogOut.Location = new Point(11, 315);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(147, 38);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(11, 84, 128);
            btnDashboard.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDashboard.Location = new Point(11, 7);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(147, 38);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(11, 84, 128);
            btnSettings.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSettings.Location = new Point(11, 271);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(147, 38);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Ayarlar";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnBankProcess
            // 
            btnBankProcess.BackColor = Color.FromArgb(11, 84, 128);
            btnBankProcess.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBankProcess.Location = new Point(11, 183);
            btnBankProcess.Name = "btnBankProcess";
            btnBankProcess.Size = new Size(147, 38);
            btnBankProcess.TabIndex = 0;
            btnBankProcess.Text = "Banka Hareketleri";
            btnBankProcess.UseVisualStyleBackColor = false;
            btnBankProcess.Click += btnBankProcess_Click;
            // 
            // btnSpendings
            // 
            btnSpendings.BackColor = Color.FromArgb(11, 84, 128);
            btnSpendings.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSpendings.Location = new Point(11, 139);
            btnSpendings.Name = "btnSpendings";
            btnSpendings.Size = new Size(147, 38);
            btnSpendings.TabIndex = 0;
            btnSpendings.Text = "Giderler";
            btnSpendings.UseVisualStyleBackColor = false;
            btnSpendings.Click += btnSpendings_Click;
            // 
            // btnBills
            // 
            btnBills.BackColor = Color.FromArgb(11, 84, 128);
            btnBills.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBills.Location = new Point(11, 95);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(147, 38);
            btnBills.TabIndex = 0;
            btnBills.Text = "Faturalar";
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(11, 84, 128);
            btnCategories.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCategories.Location = new Point(11, 227);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(147, 38);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnBanks
            // 
            btnBanks.BackColor = Color.FromArgb(11, 84, 128);
            btnBanks.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBanks.Location = new Point(11, 51);
            btnBanks.Name = "btnBanks";
            btnBanks.Size = new Size(147, 38);
            btnBanks.TabIndex = 0;
            btnBanks.Text = "Bankalar";
            btnBanks.UseVisualStyleBackColor = false;
            btnBanks.Click += btnBanks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name : ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(284, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(269, 23);
            txtFirstName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 70);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "Last Name : ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(284, 67);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(269, 23);
            txtLastName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 114);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Userame : ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(284, 111);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(269, 23);
            txtUsername.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 158);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 202);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(284, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 23);
            txtPassword.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(11, 84, 128);
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(336, 291);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 38);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 241);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 7;
            label6.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(284, 238);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(269, 23);
            txtConfirmPassword.TabIndex = 8;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 84, 128);
            ClientSize = new Size(596, 363);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSettings";
            Load += FrmSettings_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogOut;
        private Button btnDashboard;
        private Button btnSettings;
        private Button btnBankProcess;
        private Button btnSpendings;
        private Button btnBills;
        private Button btnCategories;
        private Button btnBanks;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Label label6;
        private TextBox txtConfirmPassword;
    }
}