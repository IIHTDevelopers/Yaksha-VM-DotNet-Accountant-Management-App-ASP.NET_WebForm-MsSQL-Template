using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountantManagementApp.Model
{
    public class AccountantModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}