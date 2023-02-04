using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class ManagerAccounts : IAccounts
    {
        EmployeeModel IAccounts.Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@corp.com";
            output.IsManager = true;
            return output;
        }
    }
}
