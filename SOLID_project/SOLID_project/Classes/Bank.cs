using SOLID_project.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_project.Classes
{
    public class Bank
    {
        private readonly IbankingAccount _account;

        public Bank(IbankingAccount account)
        {
            _account = account;
        }

        public void ProcessTransaction(decimal amount)
        {
            _account.Withdraw(amount);
        }

        public void ProcessDeposit(decimal amount)
        {
            _account.Deposit(amount);
        }
    }
}
