using FinancialCRM.Business.Abstract;
using FinancialCRM.DataAccess.Contexts;
using FinancialCRM.Entities.Concrete;
using FinancialCRM.Entities.Enums;
using System.Data;

namespace FinancialCRM.UI
{
    public partial class FrmSpends : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;
        public FrmSpends(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
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

        private void FrmSpends_Load(object sender, EventArgs e)
        {
            cmbBank.DataSource = _bankService.GetAll().Select(bank => bank.Title).ToList();
            cmbCategory.DataSource = _categoryService.GetAll().Select(category => category.CategoryName).ToList();
            ShowBankBalance();
            SpendList();
        }

        private void SpendList()
        {
            dgvSpending.DataSource = _spendingService.GetAll()
                            .Select(x => new
                            {
                                x.Amount,
                                x.Date,
                                x.Category.CategoryName,
                                x.Title,
                                x.Id,
                            })
                            .ToList();
        }

        private void btnCreateSpend_Click(object sender, EventArgs e)
        {
            string title = txtTittle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            Spending spending = new Spending()
            {
                Amount = amount,
                Title = title,
                Date = DateTime.Now,
                CategoryId = _categoryService.GetAll().FirstOrDefault(x => x.CategoryName == cmbCategory.Text).Id
            };
            var bank = _bankService
             .GetAll(x => x.Title.Contains(cmbBank.SelectedItem.ToString()))
             .FirstOrDefault();

            if (decimal.Parse(txtAmount.Text) > bank.Balance)
            {
                MessageBox.Show("Bakiye Yetersiz İşlem İptal Edildi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear(Controls);
            }
            else
            {
                BankProcess bankProcess = new BankProcess()
                {
                    Amount = amount,
                    BankId = bank.Id,
                    Description = txtTittle.Text,
                    ProcessDate = DateTime.Now,
                    ProcessType = ProcessType.Giden
                };

                bank.Balance -= amount;

                _spendingService.Add(spending);
                _bankService.Update(bank);
                _bankProcessService.Add(bankProcess);

                MessageBox.Show("Ödeme Başaralı Bir Şekilde Sisteme Eklendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SpendList();
            Clear(Controls);
            ShowBankBalance();
        }

        private void btnRemoveSpend_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id = int.Parse(lblId.Text);
                var removeValue = _spendingService.Get(x => x.Id == id);
                _spendingService.Delete(removeValue);

                MessageBox.Show("Ödeme Başaralı Bir Şekilde Sistemden Silindi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SpendList();
                Clear(Controls);

                lblId.Text = string.Empty;
            }
        }

        private void btnUpdateSpend_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id = int.Parse(lblId.Text);
                var updateValue = _spendingService.Get(x => x.Id == id);
                updateValue.Title = txtTittle.Text;
                updateValue.Amount = decimal.Parse(txtAmount.Text);
                _spendingService.Update(updateValue);
                MessageBox.Show("Ödeme Başaralı Bir Şekilde Güncellendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SpendList();
                Clear(Controls);

                lblId.Text = string.Empty;
            }
        }

        private void ShowBankBalance()
        {
            lblBalance.Text = _bankService.GetAll(bank => bank.Title == cmbBank.SelectedItem).Select(bank => bank.Balance).FirstOrDefault().ToString();
        }

        private void dgvSpending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            decimal amount;
            string title;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                amount = decimal.Parse(dgvSpending.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
                title = dgvSpending.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                id = int.Parse(dgvSpending.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                lblId.Text = id.ToString();
                txtTittle.Text = title;
                txtAmount.Text = amount.ToString();

            }
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBankBalance();
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
                MessageBox.Show("Lütfen bir harcama seçiniz.");
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

        private void btnBills_Click(object sender, EventArgs e) => OpenForm(new FrmBilling(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBankProcess_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnCategories_Click(object sender, EventArgs e) => OpenForm(new FrmCategories(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));
        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));
        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));


    }
}
