using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement.Classes
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Money { get; set; }

        public bool Job { get; set; }
        public bool IsDebt { get; set; }
        public int DebtAmount { get; set;}
    }
}
