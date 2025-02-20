namespace FinancialCRM.UI
{
    partial class FrmSpends
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
            lblBankForm = new Label();
            panel3 = new Panel();
            dgvSpending = new DataGridView();
            btnCategories = new Button();
            btnBanks = new Button();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnDashboard = new Button();
            btnSettings = new Button();
            btnBankProcess = new Button();
            btnSpendings = new Button();
            btnBills = new Button();
            panel4 = new Panel();
            lblBalance = new Label();
            cmbCategory = new ComboBox();
            cmbBank = new ComboBox();
            label1 = new Label();
            txtTittle = new TextBox();
            lblId = new Label();
            label6 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            label7 = new Label();
            btnCreateSpend = new Button();
            btnRemoveSpend = new Button();
            btnUpdateSpend = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpending).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblBankForm
            // 
            lblBankForm.AutoSize = true;
            lblBankForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBankForm.ForeColor = SystemColors.ButtonHighlight;
            lblBankForm.Location = new Point(12, 9);
            lblBankForm.Name = "lblBankForm";
            lblBankForm.Size = new Size(103, 18);
            lblBankForm.TabIndex = 1;
            lblBankForm.Text = "Giderler Formu";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblBankForm);
            panel3.Location = new Point(-9, -3);
            panel3.Name = "panel3";
            panel3.Size = new Size(826, 39);
            panel3.TabIndex = 7;
            // 
            // dgvSpending
            // 
            dgvSpending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpending.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvSpending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpending.Location = new Point(206, 235);
            dgvSpending.Name = "dgvSpending";
            dgvSpending.Size = new Size(584, 218);
            dgvSpending.TabIndex = 6;
            dgvSpending.CellDoubleClick += dgvSpending_CellDoubleClick;
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
            panel1.Location = new Point(-16, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 421);
            panel1.TabIndex = 5;
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
            // panel4
            // 
            panel4.Controls.Add(lblBalance);
            panel4.Controls.Add(cmbCategory);
            panel4.Controls.Add(cmbBank);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtTittle);
            panel4.Controls.Add(lblId);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtAmount);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnCreateSpend);
            panel4.Controls.Add(btnRemoveSpend);
            panel4.Controls.Add(btnUpdateSpend);
            panel4.Location = new Point(206, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 187);
            panel4.TabIndex = 8;
            // 
            // lblBalance
            // 
            lblBalance.Location = new Point(387, 18);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(176, 23);
            lblBalance.TabIndex = 19;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(176, 112);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(387, 23);
            cmbCategory.TabIndex = 18;
            cmbCategory.SelectedIndexChanged += cmbBank_SelectedIndexChanged;
            // 
            // cmbBank
            // 
            cmbBank.FormattingEnabled = true;
            cmbBank.Location = new Point(178, 18);
            cmbBank.Name = "cmbBank";
            cmbBank.Size = new Size(203, 23);
            cmbBank.TabIndex = 18;
            cmbBank.SelectedIndexChanged += cmbBank_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 17;
            label1.Text = "Ödeme Yapılacak Banka:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTittle
            // 
            txtTittle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTittle.Location = new Point(176, 46);
            txtTittle.Name = "txtTittle";
            txtTittle.Size = new Size(387, 27);
            txtTittle.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblId.Location = new Point(40, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 19);
            lblId.TabIndex = 0;
            lblId.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(121, 46);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 0;
            label6.Text = "Başlık:";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAmount.Location = new Point(176, 79);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(387, 27);
            txtAmount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(105, 112);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 0;
            label2.Text = "Kategori:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(117, 79);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 0;
            label7.Text = "Miktar:";
            // 
            // btnCreateSpend
            // 
            btnCreateSpend.BackColor = Color.FromArgb(11, 84, 128);
            btnCreateSpend.Font = new Font("Calibri", 10F);
            btnCreateSpend.Location = new Point(116, 136);
            btnCreateSpend.Name = "btnCreateSpend";
            btnCreateSpend.Size = new Size(151, 38);
            btnCreateSpend.TabIndex = 0;
            btnCreateSpend.Text = "Yeni Harcama";
            btnCreateSpend.UseVisualStyleBackColor = false;
            btnCreateSpend.Click += btnCreateSpend_Click;
            // 
            // btnRemoveSpend
            // 
            btnRemoveSpend.BackColor = Color.FromArgb(11, 84, 128);
            btnRemoveSpend.Font = new Font("Calibri", 10F);
            btnRemoveSpend.Location = new Point(273, 136);
            btnRemoveSpend.Name = "btnRemoveSpend";
            btnRemoveSpend.Size = new Size(151, 38);
            btnRemoveSpend.TabIndex = 0;
            btnRemoveSpend.Text = "Harcama Sil";
            btnRemoveSpend.UseVisualStyleBackColor = false;
            btnRemoveSpend.Click += btnRemoveSpend_Click;
            // 
            // btnUpdateSpend
            // 
            btnUpdateSpend.BackColor = Color.FromArgb(11, 84, 128);
            btnUpdateSpend.Font = new Font("Calibri", 10F);
            btnUpdateSpend.Location = new Point(430, 136);
            btnUpdateSpend.Name = "btnUpdateSpend";
            btnUpdateSpend.Size = new Size(151, 38);
            btnUpdateSpend.TabIndex = 0;
            btnUpdateSpend.Text = "Harcamayı Güncelle";
            btnUpdateSpend.UseVisualStyleBackColor = false;
            btnUpdateSpend.Click += btnUpdateSpend_Click;
            // 
            // FrmSpends
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dgvSpending);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSpends";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSpends";
            Load += FrmSpends_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpending).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBankForm;
        private Panel panel3;
        private DataGridView dgvSpending;
        private Button btnCategories;
        private Button btnBanks;
        private Panel panel1;
        private Button btnLogOut;
        private Button btnDashboard;
        private Button btnSettings;
        private Button btnBankProcess;
        private Button btnSpendings;
        private Button btnBills;
        private Panel panel4;
        private TextBox txtTittle;
        private Label label6;
        private TextBox txtAmount;
        private Label label7;
        private Button btnCreateSpend;
        private Button btnRemoveSpend;
        private Button btnUpdateSpend;
        private Label lblBalance;
        private ComboBox cmbBank;
        private Label label1;
        private Label lblId;
        private ComboBox cmbCategory;
        private Label label2;
    }
}