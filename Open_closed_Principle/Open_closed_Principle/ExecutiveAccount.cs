using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    internal class ExecutiveAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@corp.com";
            output.IsManager = true;
            //assim o usuário se torna um executivo
            output.IsExecutive = true;
            return output;
        }
    }
}
