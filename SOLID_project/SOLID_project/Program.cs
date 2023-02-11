using SOLID_project.Classes;
using SOLID_project.Interface;

//Dessa forma definimos uma conta qualquer levando o tipo primario como a interface
//que é implementada por BankAccount e SavingsAccount.Assim fazemos um downcasting definindo que o mesmo será um BankAccount.

IbankingAccount account = new BankAccount { AccountNumber = 1, Name = "Henrique", Balance = 800};

/*Logo depois definimos que uma classe henriqueAccount do tipo Bank para poder realizar as devidas operações, assim para que esse metódo em qualquer classe funcione
 usando uma injeção de dependencia*/

Bank henriqueAccount = new Bank(account);

henriqueAccount.ProcessTransaction(200);
henriqueAccount.ProcessDeposit(1000);


Console.WriteLine($"Nome:{account}");
