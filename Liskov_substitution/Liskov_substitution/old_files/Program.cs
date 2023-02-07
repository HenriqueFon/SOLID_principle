///*Liskov se S é um subtipo de T, T pode substituir S sem que o programa
// pare de funcionar.

//  Por exemplo, se eu substituir a linha 15 Employee emp = new Employee();
//  por new Manager, o programa ainda sim não quebraria.
// */

//using Liskov_substitution.types_of_employee;

//Manager accountingVP = new Manager();

//accountingVP.FirstName = "Emma";
//accountingVP.LastName = "Stone";
//accountingVP.CalculatePerHourRate(4);

//Employee emp = new Employee();

//emp.FirstName = "Tim";
//emp.LastName = "Corey";
//emp.AssignManager(accountingVP);
//emp.CalculatePerHourRate(2);

//Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour");
//Console.ReadLine();