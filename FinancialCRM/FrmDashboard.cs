using FinancialCRM.DataAccess.Contexts;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.Data;
using FinancialCRM.Business.Abstract;
using Autofac;
using FinancialCRM.Business.Concrete;
using FinancialCRM.DataAccess.Concrete;
using FinancialCRM.Business.Validation.FluentValidation;
using FinancialCRM.Entities.Concrete;

namespace FinancialCRM.UI
{
    public partial class FrmDashboard : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;

        int count = 0;

        public FrmDashboard(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
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

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = _bankService.GetAll().Sum(x => x.Balance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";
            ShowBills();
            var lastBankProcessAmount = _bankProcessService.GetAll()
                .OrderByDescending(x => x.Id)
                .Select(x => x.Amount)
                .FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString();

            ChartBanks();
            ChartBills();
        }

        private void ChartBanks()
        {
            var bankData = _bankService.GetAll().Select(x => new
            {
                x.Title,
                x.Balance
            }).ToList();

            chartBanks.Series = new ISeries[]
            {
                new ColumnSeries<decimal>
                {
                    Values = bankData.Select(x => x.Balance).ToArray(),
                    Name = "Balances"
                }
            };
            chartBanks.XAxes = new[]
            {
                new Axis
                {
                    Labels = bankData.Select(x => x.Title).ToArray(),
                    Name = "Banks"
                }
            };

            chartBanks.YAxes = new[]
            {
                new Axis
                {
                    Name = "Balance"
                }
            };
        }

        private void ChartBills()
        {
            var billData = _billService.GetAll().Select(x => new
            {
                x.Title,
                x.Amount
            }).ToList();

            chartBills.Series = new ISeries[]
            {
                new ColumnSeries<decimal>
                {
                    Values = billData.Select(x => x.Amount).ToArray(),
                    Name = "Amounts"
                }
            };
            chartBills.XAxes = new[]
            {
                new Axis
                {
                    Labels = billData.Select(x => x.Title).ToArray(),
                    Name = "Bills"
                }
            };

            chartBills.YAxes = new[]
            {
                new Axis
                {
                    Name = "Amount"
                }
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowBills();
        }


        private void ShowBills()
        {
            var billTitle = _billService.GetAll().Select(x => x.Title).ToList();
            lblBillTitle.Text = billTitle[count % billTitle.Count];
            var billAmount = _billService.GetAll().Select(x => x.Amount).ToList();
            lblBillAmount.Text = billAmount[count % billAmount.Count].ToString();
            count++;
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e) => OpenForm(new FrmBanks(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBills_Click(object sender, EventArgs e) => OpenForm(new FrmBilling(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSpendings_Click(object sender, EventArgs e) => OpenForm(new FrmSpends(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBankProcess_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnCategories_Click(object sender, EventArgs e) => OpenForm(new FrmCategories(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

    }
}
