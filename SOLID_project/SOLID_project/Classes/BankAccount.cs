using SOLID_project.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_project.Classes
{
    /*Single Responsibility Principle (SRP)
    Criaremos uma classe para gerenciar a conta bancária individual, 
    que será responsável por lidar com operações de depósito, 
    saque e consulta de saldo.*/
    public class BankAccount : IbankingAccount
    { 
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

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
