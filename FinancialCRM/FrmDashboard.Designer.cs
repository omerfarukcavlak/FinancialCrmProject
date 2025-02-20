using LiveChartsCore.SkiaSharpView.WinForms;

namespace FinancialCRM.UI
{
    partial class FrmDashboard
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnDashboard = new Button();
            btnSettings = new Button();
            btnBankProcess = new Button();
            btnSpendings = new Button();
            btnCategories = new Button();
            btnBills = new Button();
            btnBanks = new Button();
            panel2 = new Panel();
            lblBankForm = new Label();
            panel3 = new Panel();
            lblTotalBalance = new Label();
            label1 = new Label();
            panel4 = new Panel();
            lblBillAmount = new Label();
            lblBillTitle = new Label();
            panel5 = new Panel();
            lblLastBankProcessAmount = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            chartBanks = new CartesianChart();
            chartBills = new CartesianChart();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
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
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnBills);
            panel1.Controls.Add(btnBanks);
            panel1.Location = new Point(-7, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 421);
            panel1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblBankForm);
            panel2.Location = new Point(-8, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 32);
            panel2.TabIndex = 5;
            // 
            // lblBankForm
            // 
            lblBankForm.AutoSize = true;
            lblBankForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBankForm.ForeColor = SystemColors.ButtonHighlight;
            lblBankForm.Location = new Point(12, 9);
            lblBankForm.Name = "lblBankForm";
            lblBankForm.Size = new Size(202, 18);
            lblBankForm.TabIndex = 1;
            lblBankForm.Text = "Dashboard / Genel Bakış Formu";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 188, 156);
            panel3.Controls.Add(lblTotalBalance);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(196, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 96);
            panel3.TabIndex = 6;
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalBalance.ForeColor = SystemColors.ButtonHighlight;
            lblTotalBalance.Location = new Point(1, 40);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(194, 42);
            lblTotalBalance.TabIndex = 0;
            lblTotalBalance.Text = "0.00 ₺";
            lblTotalBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Toplam Bakiyem";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Controls.Add(lblBillAmount);
            panel4.Controls.Add(lblBillTitle);
            panel4.Location = new Point(397, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 96);
            panel4.TabIndex = 7;
            // 
            // lblBillAmount
            // 
            lblBillAmount.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBillAmount.ForeColor = SystemColors.ButtonHighlight;
            lblBillAmount.Location = new Point(0, 40);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(194, 42);
            lblBillAmount.TabIndex = 0;
            lblBillAmount.Text = "0.00 ₺";
            lblBillAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBillTitle
            // 
            lblBillTitle.AutoSize = true;
            lblBillTitle.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBillTitle.ForeColor = SystemColors.ButtonHighlight;
            lblBillTitle.Location = new Point(3, 13);
            lblBillTitle.Name = "lblBillTitle";
            lblBillTitle.Size = new Size(81, 15);
            lblBillTitle.TabIndex = 0;
            lblBillTitle.Text = "Fatura Başlığı";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(155, 89, 182);
            panel5.Controls.Add(lblLastBankProcessAmount);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(600, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 96);
            panel5.TabIndex = 8;
            // 
            // lblLastBankProcessAmount
            // 
            lblLastBankProcessAmount.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblLastBankProcessAmount.ForeColor = SystemColors.ButtonHighlight;
            lblLastBankProcessAmount.Location = new Point(3, 40);
            lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            lblLastBankProcessAmount.Size = new Size(200, 42);
            lblLastBankProcessAmount.TabIndex = 0;
            lblLastBankProcessAmount.Text = "0.00 ₺";
            lblLastBankProcessAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 0;
            label3.Text = "Gelen Son Havale";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // chartBanks
            // 
            chartBanks.Location = new Point(200, 244);
            chartBanks.MatchAxesScreenDataRatio = false;
            chartBanks.Name = "chartBanks";
            chartBanks.Size = new Size(295, 182);
            chartBanks.TabIndex = 0;
            // 
            // chartBills
            // 
            chartBills.Location = new Point(500, 244);
            chartBills.MatchAxesScreenDataRatio = false;
            chartBills.Name = "chartBills";
            chartBills.Size = new Size(295, 182);
            chartBills.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(199, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(296, 66);
            panel6.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 66);
            label2.TabIndex = 0;
            label2.Text = "Bankalar ve banka hesaplarındaki para\r\n miktarlarına aşağıdaki grafikten ulaşabilirsiniz.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(500, 160);
            panel7.Name = "panel7";
            panel7.Size = new Size(296, 66);
            panel7.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(296, 66);
            label4.TabIndex = 0;
            label4.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına aşağıdaki grafikten ulaşabilirsiniz.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(chartBanks);
            Controls.Add(chartBills);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel2;
        private Label lblBankForm;
        private Panel panel3;
        private Label lblTotalBalance;
        private Label label1;
        private Panel panel4;
        private Label lblBillAmount;
        private Label lblBillTitle;
        private Panel panel5;
        private Label lblLastBankProcessAmount;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private CartesianChart chartBanks;
        private CartesianChart chartBills;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private Label label4;
    }
}