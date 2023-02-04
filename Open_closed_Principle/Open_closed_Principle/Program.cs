using Open_closed_Principle;

/*The OCP principle says that a feature when in development should be open
 to extension but closed to modification. When new features have to be created
 we extend the class but not alter the original code.
 
 Changes in a existing class can create bugs to a code that already works.

 How to change a feature in code withou changing an working code?
 Answer: Separate extensible behavior behind an interface, and flip the dependencies.

 Ou seja, abstrair os aspectos essenciais em uma interface quando em produção.

 Quando está no desenvolvimento classes podem ser alteradas quando quiser exceto
 quando em produção teriamos que usar OCP.
 */

//Criar uma lista da interface IApplicantModel e definir instâncias de new PersonModel
//não é um problema porque PersonModel implementa a interface em questão.

/*Caso seja necessário adicionar um novo tipo de empregado, no caso manager, eu crio
  uma classe ManagerModel e implemento a classe IApplicantModel*/

/*Prova: Criar uma classe de executivo*/

List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new PersonModel { FirstName = "Tim", LastName = "Corey" },
    new ManagerModel { FirstName = "Sue", LastName = "Storm" },
    new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }
};

List<EmployeeModel> employees = new List<EmployeeModel>();


foreach( var person in applicants)
{
    //Dentro de person que é originado de applicants eu chamo Account Processor
    //que vem da classe Accounts onde chamo a função de create person
    employees.Add(person.AccountProcessor.Create(person));
}

foreach( var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAdress} isManager: {emp.IsManager} isExecutive: {emp.IsExecutive}");
}

Console.ReadLine();