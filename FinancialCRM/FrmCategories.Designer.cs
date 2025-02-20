namespace FinancialCRM.UI
{
    partial class FrmCategories
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
            dgvCategoryList = new DataGridView();
            txtCategoryName = new TextBox();
            panel2 = new Panel();
            lblId = new Label();
            btnRemoveCategory = new Button();
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            label4 = new Label();
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
            lblMostSpendingCategory = new Label();
            label1 = new Label();
            panel5 = new Panel();
            lblPopularCategory = new Label();
            label2 = new Label();
            panel6 = new Panel();
            lblCategoryCount = new Label();
            label3 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblBankForm
            // 
            lblBankForm.AutoSize = true;
            lblBankForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBankForm.ForeColor = SystemColors.ButtonHighlight;
            lblBankForm.Location = new Point(12, 9);
            lblBankForm.Name = "lblBankForm";
            lblBankForm.Size = new Size(120, 18);
            lblBankForm.TabIndex = 1;
            lblBankForm.Text = "Kategoriler Formu";
            lblBankForm.TextAlign = ContentAlignment.MiddleCenter;
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
            // dgvCategoryList
            // 
            dgvCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoryList.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryList.Location = new Point(176, 12);
            dgvCategoryList.Name = "dgvCategoryList";
            dgvCategoryList.Size = new Size(422, 198);
            dgvCategoryList.TabIndex = 6;
            dgvCategoryList.CellDoubleClick += dgvCategoryList_CellDoubleClick;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCategoryName.Location = new Point(15, 40);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(144, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(txtCategoryName);
            panel2.Controls.Add(dgvCategoryList);
            panel2.Controls.Add(btnRemoveCategory);
            panel2.Controls.Add(btnUpdateCategory);
            panel2.Controls.Add(btnAddCategory);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(206, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 213);
            panel2.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(106, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 7;
            lblId.Visible = false;
            // 
            // btnRemoveCategory
            // 
            btnRemoveCategory.BackColor = Color.FromArgb(11, 84, 128);
            btnRemoveCategory.Font = new Font("Calibri", 10F);
            btnRemoveCategory.Location = new Point(9, 161);
            btnRemoveCategory.Name = "btnRemoveCategory";
            btnRemoveCategory.Size = new Size(150, 38);
            btnRemoveCategory.TabIndex = 0;
            btnRemoveCategory.Text = "Kategori Sil";
            btnRemoveCategory.UseVisualStyleBackColor = false;
            btnRemoveCategory.Click += btnRemoveCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.BackColor = Color.FromArgb(11, 84, 128);
            btnUpdateCategory.Font = new Font("Calibri", 10F);
            btnUpdateCategory.Location = new Point(9, 117);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(150, 38);
            btnUpdateCategory.TabIndex = 0;
            btnUpdateCategory.Text = "Kategori Güncelle";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(11, 84, 128);
            btnAddCategory.Font = new Font("Calibri", 10F);
            btnAddCategory.Location = new Point(9, 73);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(150, 38);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Kategori Ekle";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 0;
            label4.Text = "Kategori:";
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
            btnBills.Click += btnBills_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 188, 156);
            panel4.Controls.Add(lblMostSpendingCategory);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(206, 279);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 96);
            panel4.TabIndex = 9;
            // 
            // lblMostSpendingCategory
            // 
            lblMostSpendingCategory.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMostSpendingCategory.ForeColor = SystemColors.ButtonHighlight;
            lblMostSpendingCategory.Location = new Point(3, 44);
            lblMostSpendingCategory.Name = "lblMostSpendingCategory";
            lblMostSpendingCategory.Size = new Size(194, 42);
            lblMostSpendingCategory.TabIndex = 0;
            lblMostSpendingCategory.Text = "0.00 ₺";
            lblMostSpendingCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 0;
            label1.Text = "En Çok Para Harcanan Kategori";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Controls.Add(lblPopularCategory);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(410, 279);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 96);
            panel5.TabIndex = 10;
            // 
            // lblPopularCategory
            // 
            lblPopularCategory.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPopularCategory.ForeColor = SystemColors.ButtonHighlight;
            lblPopularCategory.Location = new Point(6, 44);
            lblPopularCategory.Name = "lblPopularCategory";
            lblPopularCategory.Size = new Size(191, 42);
            lblPopularCategory.TabIndex = 0;
            lblPopularCategory.Text = "0.00 ₺";
            lblPopularCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 0;
            label2.Text = "En Çok İşlem Yapılan Kategori";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(155, 89, 182);
            panel6.Controls.Add(lblCategoryCount);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(620, 279);
            panel6.Name = "panel6";
            panel6.Size = new Size(197, 96);
            panel6.TabIndex = 11;
            // 
            // lblCategoryCount
            // 
            lblCategoryCount.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCategoryCount.ForeColor = SystemColors.ButtonHighlight;
            lblCategoryCount.Location = new Point(0, 44);
            lblCategoryCount.Name = "lblCategoryCount";
            lblCategoryCount.Size = new Size(194, 42);
            lblCategoryCount.TabIndex = 0;
            lblCategoryCount.Text = "0.00 ₺";
            lblCategoryCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 0;
            label3.Text = "Toplam Kategori Sayısı";
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 415);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategories";
            Load += FrmCategories_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBankForm;
        private Panel panel3;
        private DataGridView dgvCategoryList;
        private TextBox txtCategoryName;
        private Panel panel2;
        private Label label4;
        private Button btnUpdateBill;
        private Button btnRemoveBill;
        private Button btnAddCategory;
        private Button btnBillList;
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
        private Label lblMostSpendingCategory;
        private Label label1;
        private Panel panel5;
        private Label lblPopularCategory;
        private Label label2;
        private Panel panel6;
        private Label lblCategoryCount;
        private Label label3;
        private Button btnRemoveCategory;
        private Button btnUpdateCategory;
        private Label lblId;
    }
}