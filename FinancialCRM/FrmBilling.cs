using FinancialCRM.Entities.Concrete;
using FinancialCRM.Business.Abstract;
using FinancialCRM.Entities.Enums;

namespace FinancialCRM.UI
{
    public partial class FrmBilling : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;


        public FrmBilling(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
        {
            InitializeComponent();
            _bankService = bankService;
            _bankProcessService = bankProcessService;
            _billService = billService;
            _categoryService = categoryService;
            _spendingService = spendingService;
            _user = user;
            _registerService = registerService;
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            cmbBank.DataSource = _bankService.GetAll().Select(bank => bank.Title).ToList();
            ShowBankBalance();
            BillList();
        }
        private void BillList()

        {
            var values = _billService.GetAll().ToList();
            dgvBills.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            var bank = _bankService
                .GetAll(x => x.Title.Contains(cmbBank.SelectedItem.ToString()))
                .FirstOrDefault();

            Bill bill = new Bill()
            {
                Amount = amount,
                Period = period,
                Title = title,
            };

            if (decimal.Parse(txtBillAmount.Text) > bank.Balance)
            {
                MessageBox.Show("Bakiye Yetersiz İşlem İptal Edildi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear(Controls);
            }
            else
            {
                BankProcess bankProcess = new BankProcess()
                {
                    Amount = amount,
                    BankId = bank.Id,
                    Description = txtBillPeriod.Text + " " + txtBillTitle.Text,
                    ProcessDate = DateTime.Now,
                    ProcessType = ProcessType.Giden
                };

                bank.Balance -= amount;

                _billService.Add(bill);
                _bankService.Update(bank);
                _bankProcessService.Add(bankProcess);

                MessageBox.Show("Ödeme Başaralı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BillList();
            Clear(Controls);
            ShowBankBalance();

        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id = int.Parse(lblId.Text);
                var removeValue = _billService.Get(x => x.Id == id);
                _billService.Delete(removeValue);

                MessageBox.Show("Ödeme Başaralı Bir Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BillList();
                Clear(Controls);

                lblId.Text = string.Empty;
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id = int.Parse(lblId.Text);
                var updateValue = _billService.Get(x => x.Id == id);
                updateValue.Title = txtBillTitle.Text;
                updateValue.Period = txtBillPeriod.Text;
                updateValue.Amount = decimal.Parse(txtBillAmount.Text);
                _billService.Update(updateValue);
                MessageBox.Show("Ödeme Başaralı Bir Şekilde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BillList();
                Clear(Controls);

                lblId.Text = string.Empty;
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            decimal amount;
            string title, period;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                id = int.Parse(dgvBills.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                amount = decimal.Parse(dgvBills.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
                title = dgvBills.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                period = dgvBills.Rows[e.RowIndex].Cells["Period"].Value.ToString();

                lblId.Text = id.ToString();
                txtBillTitle.Text = title;
                txtBillAmount.Text = amount.ToString();
                txtBillPeriod.Text = period;

            }
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBankBalance();
        }

        private void ShowBankBalance()
        {
            lblBalance.Text = _bankService.GetAll(bank => bank.Title == cmbBank.SelectedItem).Select(bank => bank.Balance).FirstOrDefault().ToString();
        }

        private void Clear(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case Panel panel:
                        Clear(panel.Controls);
                        break;
                }
            }
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(lblId.Text))
            {
                MessageBox.Show("Lütfen bir fatura seçiniz.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBanks_Click(object sender, EventArgs e) => OpenForm(new FrmBanks(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSpendings_Click(object sender, EventArgs e) => OpenForm(new FrmSpends(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBankProcess_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnCategories_Click(object sender, EventArgs e) => OpenForm(new FrmCategories(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

    }
}
