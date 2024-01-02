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
        static string ID;
        private void BindGridView()
        {
            var query = _accountantService.GetAll();
            _dataLayer.fillgridView(query, gv);
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = gv.SelectedRow.Cells[1].Text.ToString();
            txtFirstName.Text = gv.SelectedRow.Cells[2].Text.ToString();
            txtLastName.Text = gv.SelectedRow.Cells[3].Text.ToString();
            txtDateOfBirth.Text = gv.SelectedRow.Cells[4].Text.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var query = _accountantService.Add();
            string qry = query + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtDateOfBirth.Text + "')";
            lblMessage.Text = _dataLayer.insertUpdateCreateOrDelete(qry);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDateOfBirth.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var query = _accountantService.Update();
            string qry = query + txtFirstName.Text + "',LastName='" + txtLastName.Text + "',DateOfBirth='" + txtDateOfBirth.Text+"'";
            lblMessage.Text = _dataLayer.insertUpdateCreateOrDelete(qry);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDateOfBirth.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var query = _accountantService.Delete();
            string qry = query + ID + "'";
            lblMessage.Text = _dataLayer.insertUpdateCreateOrDelete(qry);
        }
    }
}
