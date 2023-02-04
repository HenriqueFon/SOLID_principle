using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    internal class Accounts : IAccounts
    {
        /*Function to convert a PersonModel to EmployeeModel*/
        /*Now I call the interface of ApplicantModel for person that implements
         PersonModel*/
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            /*Example: hAraujo@gmail.com*/
            output.EmailAdress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@gmail.com";

            //This if does not respect ocp
            //if(person.TypeOfEmployee == EmployeeType.Manager)
            //{
            //    output.IsManager = true;
            //}

            return output;
        }
    }
}
