using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement.Classes
{
    internal class Bank
    {
        
        public int Debt {  get; set; }

        public int Balance { get; set; }

        public void Deposit (User user , int amount)
        {
            Balance += amount;
            Console.WriteLine($"This amount of money has been deposited: {amount}\nDeposited account name: {user.Name}\nThis is your current balance: {Balance}\n");
        }

        public void Withdraw (int amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"This amount of money has been withdrawed: {amount}\nThis is your current balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"You can not withdraw money this is your balance:{Balance}. This is money amount you want to withdraw: {amount}.");
            }
        }

        public void Loan(User user, int loan)
        {
            if (user.Money <= 500 || user.IsDebt == true || user.Job == false || user.Salary <= 1500)
            {
                Console.WriteLine($"Sorry, you are not eligible for a loan.");
            }
            else
            {
                user.DebtAmount += loan;
                Console.WriteLine($"You are eligible for a loan.You have recevied this amount of loan: {loan}\n");
            }
        }
        public void CheckBalance(User user)
        {
            Console.WriteLine($"Account Balance for {user.Name}: {Balance}\nYour current Debt: {user.DebtAmount}\n" );
           
        }
    }
}
