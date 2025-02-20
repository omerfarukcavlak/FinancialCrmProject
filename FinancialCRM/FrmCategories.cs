using FinancialCRM.Entities.Concrete;
using FinancialCRM.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Data;
using FinancialCRM.Business.Abstract;
using FinancialCRM.Business.Concrete;
using FinancialCRM.Business.Validation.FluentValidation;
using FinancialCRM.DataAccess.Concrete;

namespace FinancialCRM.UI
{
    public partial class FrmCategories : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IBankService _bankService;
        private readonly IBankProcessService _bankProcessService;
        private readonly IBillService _billService;
        private readonly ICategoryService _categoryService;
        private readonly ISpendingService _spendingService;
        User _user;

        public FrmCategories(IRegisterService registerService, IBankService bankService, IBankProcessService bankProcessService, IBillService billService, ICategoryService categoryService, ISpendingService spendingService, User user)
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

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            CategoryList();

            lblMostSpendingCategory.Text = _spendingService.GetAll()
                .GroupBy(x => new { x.CategoryId, x.Category.CategoryName })
                .Select(g => new
                {
                    g.Key.CategoryName,
                    Amount = g.Sum(x => x.Amount)
                })
                .OrderByDescending(x => x.Amount)
                .FirstOrDefault()
                .CategoryName;

            lblPopularCategory.Text = _spendingService.GetAll()
                .GroupBy(x => new { x.CategoryId, x.Category.CategoryName })
                .Select(g => new
                {
                    g.Key.CategoryName,
                    Count = g.Count()
                })
                .OrderByDescending(x => x.Count)
                .FirstOrDefault()
                .CategoryName;

            lblCategoryCount.Text = _categoryService.GetAll().Count().ToString();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryName = txtCategoryName.Text,
            };
            _categoryService.Add(category);
            MessageBox.Show("Ödeme Başaralı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CategoryList();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id = int.Parse(lblId.Text);
                var updateValue = _categoryService.Get(x => x.Id == id);
                updateValue.CategoryName = txtCategoryName.Text;

                _categoryService.Update(updateValue);

                MessageBox.Show("Kategori Başaralı Bir Şekilde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CategoryList();
                txtCategoryName.Clear();
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id = int.Parse(lblId.Text);
                var deletedValue = _categoryService.Get(x => x.Id == id);

                _categoryService.Delete(deletedValue);

                MessageBox.Show("Kategori Başaralı Bir Şekilde Sistemden Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CategoryList();
                txtCategoryName.Clear();
            }
        }

        private void dgvCategoryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string category;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = int.Parse(dgvCategoryList.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                lblId.Text = id.ToString();
                category = dgvCategoryList.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();

                txtCategoryName.Text = category;
            }
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(lblId.Text))
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CategoryList()
        {
            dgvCategoryList.DataSource = _categoryService.GetAll().ToList();
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

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService, _user));

        private void btnLogOut_Click(object sender, EventArgs e) => OpenForm(new LoginUI(_registerService, _bankService, _bankProcessService, _billService, _categoryService, _spendingService));

    }
}
