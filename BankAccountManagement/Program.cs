using BankAccountManagement.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a User object
            User user = new User
            {
                Name = "John",
                Surname = "Doe",
                Salary = 2000,
                Money = 1000,
                Job = true,
                IsDebt = false
            };

            User user2 = new User
            {
                Name = "Riad",
                Surname = "Veliyev",
                Salary = 5,
                Money = 10,
                Job = false,
                IsDebt = true
            };

            // Code below makes bank operations such as withdrawing,deposit,getting loan and checking balance for user1

            // Create a Bank object
            Bank bank = new Bank();

            // Deposit money into the bank account
            bank.Deposit(user,500);

            // Withdraw money from the bank account
            bank.Withdraw(500);

            // Check balance and debt
            bank.CheckBalance(user);

            // Request a loan
            bank.Loan(user, 2000);

            // Check balance and debt
            bank.CheckBalance(user);

            Console.WriteLine("**********************************************************************************");

            // Code below makes bank operations such as withdrawing,deposit,getting loan and checking balance for user2

            // Deposit money into the bank account
            bank.Deposit(user2,200);

            // Withdraw money from the bank account
            bank.Withdraw(500);

            // Check balance and debt
            bank.CheckBalance(user2);

            // Request a loan
            bank.Loan(user2, 2000);

            // Check balance and debt
            bank.CheckBalance(user2);
        }
    }
}
