using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AccountantManagementApp.DAL.Interfaces;

namespace AccountantManagementApp.DAL.Services
{
    public class AccountantRepository : Interfaces.IAccountantRepository
    {
        private AccountantDbContext _context;

        public AccountantRepository(AccountantDbContext context)
        {
            _context = context;
        }

        public Model.AccountantModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
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
    }
}