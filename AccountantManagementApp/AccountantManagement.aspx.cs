using AccountantManagementApp.DAL;
using AccountantManagementApp.Model;
using System;
using System.Web.UI;

namespace AccountantManagementApp
{
    public partial class AccountantManagement : Page
    {
        private readonly datalayer _dataLayer;
        private readonly AccountantManagementApp.DAL.Interfaces.IAccountantService _accountantService;

        public AccountantManagement()
        {
            _dataLayer = new datalayer();
            _accountantService = new DAL.Services.AccountantService(new DAL.Services.AccountantRepository(new AccountantManagementApp.DAL.AccountantDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            var accountants = _accountantService.GetAll();
            _dataLayer.fillgridView(accountants, gv);
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = gv.SelectedRow.Cells[1].Text;
            // Retrieve the accountant details and populate the form
            var accountant = _accountantService.GetById(id);
            if (accountant != null)
            {
                txtFirstName.Text = accountant.FirstName;
                txtLastName.Text = accountant.LastName;
                txtDateOfBirth.Text = accountant.DateOfBirth.ToString("yyyy-MM-dd");
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            var newAccountant = new AccountantModel
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = DateTime.Parse(txtDateOfBirth.Text)
            };

            _accountantService.Add();
            BindGridView();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            string id = gv.SelectedRow.Cells[1].Text.ToString();
            var existingAccountant = _accountantService.GetById(id);

            if (existingAccountant != null)
            {
                existingAccountant.LastName = txtLastName.Text;
                existingAccountant.FirstName = txtFirstName.Text;
                existingAccountant.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);

                _accountantService.Update();
                BindGridView();
            }
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            string id = gv.SelectedRow.Cells[1].Text.ToString();
            _accountantService.Delete();
            BindGridView();
        }
    }
}
