using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AccountantManagementApp.DAL.Interfaces;
using AccountantManagementApp.Model;

namespace AccountantManagementApp.DAL.Services
{
    public class AccountantService : Interfaces.IAccountantService
    {
        private Interfaces.IAccountantRepository _repository;

        public AccountantService(Interfaces.IAccountantRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public AccountantModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}