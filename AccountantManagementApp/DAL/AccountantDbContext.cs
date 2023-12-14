using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AccountantManagementApp.Model;

namespace AccountantManagementApp.DAL
{
    public class AccountantDbContext : DbContext
    {
        public DbSet<Model.AccountantModel> AccountantModels { get; set; }

        public AccountantDbContext() : base("ConnStr")
        {
        }
    }
}