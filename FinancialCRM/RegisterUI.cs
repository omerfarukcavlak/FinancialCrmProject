using FinancialCRM.Business.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
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
    public partial class RegisterUI : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        public RegisterUI(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService)
        {
            InitializeComponent();
            _registerService = registerService;
            _bankService = bankService;
            _bankProcessService = bankProcessService;
            _billService = billService;
            _categoryService = categoryService;
            _spendingService = spendingService;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text,
            };
            try
            {
                if (_registerService.Add(user))
                {
                    MessageBox.Show("Membership has been successfully created.");
                    OpenForm(new LoginUI(_registerService,_bankService,_bankProcessService,_billService,_categoryService,_spendingService));
                }
            }
            catch (ValidationException exc)
            {
                var errorMessage = "There were validation errors:\n\n";

                foreach (var error in exc.Errors)
                {
                    errorMessage += "- " + error.ErrorMessage + "\n";
                }

                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occurred: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                e.Handled = true;
            }
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void llblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
