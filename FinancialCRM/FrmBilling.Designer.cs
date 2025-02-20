namespace FinancialCRM.UI
{
    partial class FrmBilling
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
            dgvBills = new DataGridView();
            panel3 = new Panel();
            lblBankForm = new Label();
            txtBillPeriod = new TextBox();
            txtBillTitle = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtBillAmount = new TextBox();
            label3 = new Label();
            btnUpdateBill = new Button();
            btnRemoveBill = new Button();
            btnCreateBill = new Button();
            lblId = new Label();
            label1 = new Label();
            cmbBank = new ComboBox();
            lblBalance = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Location = new Point(-15, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 421);
            panel1.TabIndex = 1;
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
            btnBanks.Click += btnBanks_Click;
            // 
            // dgvBills
            // 
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBills.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Location = new Point(207, 237);
            dgvBills.Name = "dgvBills";
            dgvBills.Size = new Size(554, 218);
            dgvBills.TabIndex = 2;
            dgvBills.CellDoubleClick += dgvBills_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblBankForm);
            panel3.Location = new Point(-8, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(826, 39);
            panel3.TabIndex = 3;
            // 
            // lblBankForm
            // 
            lblBankForm.AutoSize = true;
            lblBankForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBankForm.ForeColor = SystemColors.ButtonHighlight;
            lblBankForm.Location = new Point(12, 9);
            lblBankForm.Name = "lblBankForm";
            lblBankForm.Size = new Size(106, 18);
            lblBankForm.TabIndex = 1;
            lblBankForm.Text = "Faturalar Formu";
            // 
            // txtBillPeriod
            // 
            txtBillPeriod.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBillPeriod.Location = new Point(369, 150);
            txtBillPeriod.Name = "txtBillPeriod";
            txtBillPeriod.Size = new Size(386, 27);
            txtBillPeriod.TabIndex = 12;
            // 
            // txtBillTitle
            // 
            txtBillTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBillTitle.Location = new Point(369, 84);
            txtBillTitle.Name = "txtBillTitle";
            txtBillTitle.Size = new Size(386, 27);
            txtBillTitle.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(316, 154);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 4;
            label4.Text = "Periyot:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(323, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 5;
            label2.Text = "Başlık:";
            // 
            // txtBillAmount
            // 
            txtBillAmount.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBillAmount.Location = new Point(369, 117);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(386, 27);
            txtBillAmount.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(319, 121);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 6;
            label3.Text = "Miktar:";
            // 
            // btnUpdateBill
            // 
            btnUpdateBill.BackColor = Color.FromArgb(11, 84, 128);
            btnUpdateBill.Font = new Font("Calibri", 10F);
            btnUpdateBill.Location = new Point(602, 183);
            btnUpdateBill.Name = "btnUpdateBill";
            btnUpdateBill.Size = new Size(152, 38);
            btnUpdateBill.TabIndex = 7;
            btnUpdateBill.Text = "Ödeme Güncelle";
            btnUpdateBill.UseVisualStyleBackColor = false;
            btnUpdateBill.Click += btnUpdateBill_Click;
            // 
            // btnRemoveBill
            // 
            btnRemoveBill.BackColor = Color.FromArgb(11, 84, 128);
            btnRemoveBill.Font = new Font("Calibri", 10F);
            btnRemoveBill.Location = new Point(444, 183);
            btnRemoveBill.Name = "btnRemoveBill";
            btnRemoveBill.Size = new Size(152, 38);
            btnRemoveBill.TabIndex = 8;
            btnRemoveBill.Text = "Ödeme Sil";
            btnRemoveBill.UseVisualStyleBackColor = false;
            btnRemoveBill.Click += btnRemoveBill_Click;
            // 
            // btnCreateBill
            // 
            btnCreateBill.BackColor = Color.FromArgb(11, 84, 128);
            btnCreateBill.Font = new Font("Calibri", 10F);
            btnCreateBill.Location = new Point(295, 183);
            btnCreateBill.Name = "btnCreateBill";
            btnCreateBill.Size = new Size(143, 38);
            btnCreateBill.TabIndex = 9;
            btnCreateBill.Text = "Yeni Ödeme";
            btnCreateBill.UseVisualStyleBackColor = false;
            btnCreateBill.Click += btnCreateBill_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblId.Location = new Point(223, 61);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 19);
            lblId.TabIndex = 5;
            lblId.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(201, 41);
            label1.Name = "label1";
            label1.Size = new Size(173, 48);
            label1.TabIndex = 5;
            label1.Text = "Ödeme Yapılacak Banka:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbBank
            // 
            cmbBank.FormattingEnabled = true;
            cmbBank.Location = new Point(369, 55);
            cmbBank.Name = "cmbBank";
            cmbBank.Size = new Size(203, 23);
            cmbBank.TabIndex = 15;
            cmbBank.SelectedIndexChanged += cmbBank_SelectedIndexChanged;
            // 
            // lblBalance
            // 
            lblBalance.Location = new Point(578, 55);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(176, 23);
            lblBalance.TabIndex = 16;
            // 
            // FrmBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 458);
            Controls.Add(lblBalance);
            Controls.Add(cmbBank);
            Controls.Add(txtBillPeriod);
            Controls.Add(txtBillTitle);
            Controls.Add(label4);
            Controls.Add(lblId);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtBillAmount);
            Controls.Add(label3);
            Controls.Add(btnUpdateBill);
            Controls.Add(btnRemoveBill);
            Controls.Add(btnCreateBill);
            Controls.Add(panel3);
            Controls.Add(dgvBills);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBilling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme & Fatura Bilgileri";
            Load += FrmBilling_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button btnBanks;
        private Button btnCategories;
        private DataGridView dgvBills;
        private Panel panel3;
        private Label lblBankForm;
        private TextBox txtBillPeriod;
        private TextBox txtBillTitle;
        private Label label4;
        private Label label2;
        private TextBox txtBillAmount;
        private Label label3;
        private Button btnUpdateBill;
        private Button btnRemoveBill;
        private Button btnCreateBill;
        private Label lblId;
        private Label label1;
        private ComboBox cmbBank;
        private Label lblBalance;
    }
}