using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Open/Closed Principle (OCP)
Podemos criar uma interface que defina as operações que uma 
conta bancária precisa realizar, e a classe BankAccount implementará 
essa interface. Dessa forma, podemos estender ou modificar a classe sem afetar as classes 
que dependem da interface.*/


namespace SOLID_project.Interface
{
    public interface IbankingAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
    }
}
