using FinancialCRM.Business.Abstract;
using FinancialCRM.Business.Concrete;
using FinancialCRM.Business.Validation.FluentValidation;
using FinancialCRM.DataAccess.Concrete;
using FinancialCRM.DataAccess.Contexts;
using FinancialCRM.Entities.Concrete;
using FinancialCRM.Entities.Enums;
using FinancialCRM.UI;

namespace FinancialCRM
{
    public partial class FrmBanks : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;

        public FrmBanks(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
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

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            ListBalances();

            cmbBankName.DataSource = _bankService.GetAll().Select(x => x.Title).ToList();

        }

        private void ListBalances()
        {
            var ziraatBalance = _bankService.GetAll(x => x.Title == "Ziraat Bankası").Select(x => x.Balance).FirstOrDefault();
            lblZiraatBalance.Text = ziraatBalance.ToString() + " ₺";
            var vakifBalance = _bankService.GetAll(x => x.Title == "Vakıf Bank").Select(x => x.Balance).FirstOrDefault();
            lblZiraatBalance.Text = vakifBalance.ToString() + " ₺";
            var halkBalance = _bankService.GetAll(x => x.Title == "Halk Bank").Select(x => x.Balance).FirstOrDefault();
            lblZiraatBalance.Text = ziraatBalance.ToString() + " ₺";
            lblVakifBalance.Text = vakifBalance.ToString() + " ₺";
            lblHalkBalance.Text = halkBalance.ToString() + " ₺";
        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            var entity = _bankService.Get(x => x.Title == cmbBankName.SelectedItem.ToString());
            int balance = int.Parse(txtBalance.Text);
            entity.Balance += balance;
            try
            {
                _bankService.Update(entity);

                _bankProcessService.Add(new BankProcess()
                {
                    Amount = balance,
                    Description = txtDescription.Text,
                    ProcessDate = DateTime.Now,
                    ProcessType = ProcessType.Gelen,
                    BankId = entity.Id
                });
                ListBalances();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBills_Click(object sender, EventArgs e) => OpenForm(new FrmBilling(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSpendings_Click(object sender, EventArgs e) => OpenForm(new FrmSpends(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBankProcess_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnCategories_Click(object sender, EventArgs e) => OpenForm(new FrmCategories(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

    }
}
