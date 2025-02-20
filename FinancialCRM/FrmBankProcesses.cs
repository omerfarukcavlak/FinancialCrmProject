using FinancialCRM.Business.Abstract;
using FinancialCRM.Entities.Concrete;
using FinancialCRM.Entities.Enums;
using System.Linq.Expressions;

namespace FinancialCRM.UI
{
    public partial class FrmBankProcesses : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;

        public FrmBankProcesses(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
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

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var bankList = _bankService.GetAll().Select(bank => bank.Title).ToList();
            bankList.Insert(0, "Hepsi");
            cmbBank.DataSource = bankList;
            ClearList();
            ListBankProcesses();

        }

        private void ListBankProcesses(Expression<Func<BankProcess, bool>> filter = null)
        {
            List<BankProcess> bankProcesses;
            if (filter is null)
                bankProcesses = _bankProcessService.GetAll().OrderByDescending(x => x.Id).ToList();
            else
                bankProcesses = _bankProcessService.GetAll(filter).OrderByDescending(x => x.Id).ToList();

            lstProcesses.Items.Add("Son Banka Hareketleri");
            lstProcesses.Items.Add("");

            foreach (var process in bankProcesses)
            {
                lstProcesses.Items.Add(process);
                lstProcesses.Items.Add("---------------------------------------------------------------------------------------------");
            }

            WriteBankProcesses();
        }

        private void WriteBankProcesses()
        {
            lstProcesses.DrawMode = DrawMode.OwnerDrawVariable;

            lstProcesses.MeasureItem += (s, e) =>
            {
                e.ItemHeight = 40;
            };

            lstProcesses.DrawMode = DrawMode.OwnerDrawFixed;
            lstProcesses.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;

                var item = lstProcesses.Items[e.Index];
                Color textColor = Color.White;


                if (item is BankProcess process)
                {
                    textColor = process.ProcessType == ProcessType.Gelen ? Color.Lime : Color.Red;
                }

                e.DrawBackground();
                using (Brush brush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds);
                }
                e.DrawFocusRectangle();
            };
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearList();

            DateTime? startDate = nudDate.Value > 0 ? DateTime.Now.AddDays(-(double)nudDate.Value) : null;
            string selectedBank = cmbBank.SelectedIndex == 0 ? null : cmbBank.Text;

            ListBankProcesses(x =>
                (selectedBank == null || x.Bank.Title == selectedBank) &&
                (startDate == null || x.ProcessDate >= startDate)
            );


        }

        private void ClearList()
        {
            lstProcesses.Items.Clear();
        }

        private void nudDate_ValueChanged(object sender, EventArgs e)
        {
            ClearList();

            DateTime? startDate = nudDate.Value > 0 ? DateTime.Now.AddDays(-(double)nudDate.Value) : null;
            string selectedBank = cmbBank.SelectedIndex == 0 ? null : cmbBank.Text;

            ListBankProcesses(x =>
             (selectedBank == null || x.Bank.Title == selectedBank) &&
             (startDate == null || x.ProcessDate >= startDate));
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBanks_Click(object sender, EventArgs e) => OpenForm(new FrmBanks(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnBills_Click(object sender, EventArgs e) => OpenForm(new FrmBilling(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSpendings_Click(object sender, EventArgs e) => OpenForm(new FrmSpends(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnCategories_Click(object sender, EventArgs e) => OpenForm(new FrmCategories(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

    }
}
