using FinancialCRM.Business.Abstract;
using FinancialCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCRM.UI
{
    public partial class FrmSettings : Form
    {

        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;

        public FrmSettings(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = _registerService.Get(x => x.Id == _user.Id);

            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.ConfirmPassword = txtConfirmPassword.Text;

            if(_registerService.Update(user));
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtEmail.Text = _user.Email;
            txtPassword.Text = _user.Password;
            txtFirstName.Text = _user.FirstName;
            txtLastName.Text = _user.LastName;
            txtUsername.Text = _user.Username;
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
        private void btnBankProcess_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));
        private void btnCategories_Click(object sender, EventArgs e) => OpenForm(new FrmCategories(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));
        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));
    }
}
