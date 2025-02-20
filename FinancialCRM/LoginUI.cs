using FinancialCRM.Business.Abstract;
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
    public partial class LoginUI : Form
    {
        private IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;

        public LoginUI(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService)
        {
            InitializeComponent();
            _registerService = registerService;
            _bankService = bankService;
            _bankProcessService = bankProcessService;
            _billService = billService;
            _categoryService = categoryService;
            _spendingService = spendingService;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool email = !string.IsNullOrWhiteSpace(txtEmail.Text);
            bool password = !string.IsNullOrWhiteSpace(txtPassword.Text);

            string message = "";
            message += !email ? "Email cannot be empty.\n" : "";
            message += !password ? "Password cannot be empty." : "";
            if (!string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(message);
                return;
            }
            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Split('@')[1].Contains(".")))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (email && password)
            {
                var player = _registerService.Get(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text);
                if (player is not null)
                {
                    OpenForm(new FrmDashboard(_registerService ,_bankService, _bankProcessService, _billService, _categoryService, _spendingService,player));
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }

                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
            }
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenForm(new RegisterUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

        private void LoginUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
