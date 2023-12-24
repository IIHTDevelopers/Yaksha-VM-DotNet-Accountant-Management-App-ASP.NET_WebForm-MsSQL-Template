using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountantManagementApp.Model;

namespace AccountantManagementApp.DAL.Interfaces
{
    public interface IAccountantRepository
    {
        string GetAll();
        string Add();
        string Update();
        string Delete();

        AccountantModel GetById(string id);

    }
}
