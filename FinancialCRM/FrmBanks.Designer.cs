namespace FinancialCRM
{
    partial class FrmBanks
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
            label3 = new Label();
            lblHalkBalance = new Label();
            panel5 = new Panel();
            label2 = new Label();
            lblVakifBalance = new Label();
            panel4 = new Panel();
            lblZiraatBalance = new Label();
            panel3 = new Panel();
            label1 = new Label();
            lblBankForm = new Label();
            panel2 = new Panel();
            btnCategories = new Button();
            btnBanks = new Button();
            btnBills = new Button();
            btnSpendings = new Button();
            btnBankProcess = new Button();
            btnSettings = new Button();
            btnDashboard = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            cmbBankName = new ComboBox();
            btnAddBalance = new Button();
            txtBalance = new TextBox();
            txtDescription = new TextBox();
            label5 = new Label();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Halk Bankası";
            // 
            // lblHalkBalance
            // 
            lblHalkBalance.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHalkBalance.ForeColor = SystemColors.ButtonHighlight;
            lblHalkBalance.Location = new Point(0, 44);
            lblHalkBalance.Name = "lblHalkBalance";
            lblHalkBalance.Size = new Size(194, 42);
            lblHalkBalance.TabIndex = 0;
            lblHalkBalance.Text = "0.00 ₺";
            lblHalkBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(155, 89, 182);
            panel5.Controls.Add(lblHalkBalance);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(608, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 96);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "Vakıf Bankası";
            // 
            // lblVakifBalance
            // 
            lblVakifBalance.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblVakifBalance.ForeColor = SystemColors.ButtonHighlight;
            lblVakifBalance.Location = new Point(6, 44);
            lblVakifBalance.Name = "lblVakifBalance";
            lblVakifBalance.Size = new Size(191, 42);
            lblVakifBalance.TabIndex = 0;
            lblVakifBalance.Text = "0.00 ₺";
            lblVakifBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Controls.Add(lblVakifBalance);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(405, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 96);
            panel4.TabIndex = 1;
            // 
            // lblZiraatBalance
            // 
            lblZiraatBalance.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblZiraatBalance.ForeColor = SystemColors.ButtonHighlight;
            lblZiraatBalance.Location = new Point(3, 44);
            lblZiraatBalance.Name = "lblZiraatBalance";
            lblZiraatBalance.Size = new Size(194, 42);
            lblZiraatBalance.TabIndex = 0;
            lblZiraatBalance.Text = "0.00 ₺";
            lblZiraatBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 188, 156);
            panel3.Controls.Add(lblZiraatBalance);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(204, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 96);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Ziraat Bankası";
            // 
            // lblBankForm
            // 
            lblBankForm.AutoSize = true;
            lblBankForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBankForm.ForeColor = SystemColors.ButtonHighlight;
            lblBankForm.Location = new Point(12, 9);
            lblBankForm.Name = "lblBankForm";
            lblBankForm.Size = new Size(88, 18);
            lblBankForm.TabIndex = 1;
            lblBankForm.Text = "Banka Formu";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblBankForm);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 32);
            panel2.TabIndex = 1;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(11, 84, 128);
            btnCategories.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCategories.Location = new Point(36, 247);
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
            btnBanks.Location = new Point(36, 71);
            btnBanks.Name = "btnBanks";
            btnBanks.Size = new Size(147, 38);
            btnBanks.TabIndex = 0;
            btnBanks.Text = "Bankalar";
            btnBanks.UseVisualStyleBackColor = false;
            // 
            // btnBills
            // 
            btnBills.BackColor = Color.FromArgb(11, 84, 128);
            btnBills.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBills.Location = new Point(36, 115);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(147, 38);
            btnBills.TabIndex = 0;
            btnBills.Text = "Faturalar";
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // btnSpendings
            // 
            btnSpendings.BackColor = Color.FromArgb(11, 84, 128);
            btnSpendings.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSpendings.Location = new Point(36, 159);
            btnSpendings.Name = "btnSpendings";
            btnSpendings.Size = new Size(147, 38);
            btnSpendings.TabIndex = 0;
            btnSpendings.Text = "Giderler";
            btnSpendings.UseVisualStyleBackColor = false;
            btnSpendings.Click += btnSpendings_Click;
            // 
            // btnBankProcess
            // 
            btnBankProcess.BackColor = Color.FromArgb(11, 84, 128);
            btnBankProcess.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBankProcess.Location = new Point(36, 203);
            btnBankProcess.Name = "btnBankProcess";
            btnBankProcess.Size = new Size(147, 38);
            btnBankProcess.TabIndex = 0;
            btnBankProcess.Text = "Banka Hareketleri";
            btnBankProcess.UseVisualStyleBackColor = false;
            btnBankProcess.Click += btnBankProcess_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(11, 84, 128);
            btnSettings.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSettings.Location = new Point(36, 291);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(147, 38);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Ayarlar";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(11, 84, 128);
            btnDashboard.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDashboard.Location = new Point(36, 27);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(147, 38);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(11, 84, 128);
            btnLogOut.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogOut.Location = new Point(36, 335);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(147, 38);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
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
            panel1.Location = new Point(1, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 421);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label4.Location = new Point(348, 205);
            label4.Name = "label4";
            label4.Size = new Size(110, 26);
            label4.TabIndex = 3;
            label4.Text = "Banka Adı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label7.Location = new Point(378, 288);
            label7.Name = "label7";
            label7.Size = new Size(80, 26);
            label7.TabIndex = 3;
            label7.Text = "Miktar :";
            // 
            // cmbBankName
            // 
            cmbBankName.FormattingEnabled = true;
            cmbBankName.Location = new Point(465, 203);
            cmbBankName.Name = "cmbBankName";
            cmbBankName.Size = new Size(213, 23);
            cmbBankName.TabIndex = 4;
            // 
            // btnAddBalance
            // 
            btnAddBalance.Location = new Point(362, 335);
            btnAddBalance.Name = "btnAddBalance";
            btnAddBalance.Size = new Size(316, 41);
            btnAddBalance.TabIndex = 5;
            btnAddBalance.Text = "Bakiye Yükle";
            btnAddBalance.UseVisualStyleBackColor = true;
            btnAddBalance.Click += btnAddBalance_Click;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(465, 284);
            txtBalance.Multiline = true;
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(213, 33);
            txtBalance.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(464, 237);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(213, 33);
            txtDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label5.Location = new Point(356, 244);
            label5.Name = "label5";
            label5.Size = new Size(102, 26);
            label5.TabIndex = 3;
            label5.Text = "Açıklama :";
            // 
            // FrmBanks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(817, 448);
            Controls.Add(btnAddBalance);
            Controls.Add(cmbBankName);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(txtBalance);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBanks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBanks";
            Load += FrmBanks_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label lblHalkBalance;
        private Panel panel5;
        private Label label2;
        private Label lblVakifBalance;
        private Panel panel4;
        private Label lblZiraatBalance;
        private Panel panel3;
        private Label label1;
        private Label lblBankForm;
        private Panel panel2;
        private Button btnCategories;
        private Button btnBanks;
        private Button btnBills;
        private Button btnSpendings;
        private Button btnBankProcess;
        private Button btnSettings;
        private Button btnDashboard;
        private Button btnLogOut;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private ComboBox cmbBankName;
        private Button btnAddBalance;
        private TextBox txtBalance;
        private TextBox txtDescription;
        private Label label5;
    }
}