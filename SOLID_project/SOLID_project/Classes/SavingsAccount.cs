using SOLID_project.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_project.Classes
{
    public class SavingsAccount : IbankingAccount, IsavingsAccount
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }
    }
}
