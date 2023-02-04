using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class ExecutiveModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //cria o usuário como um novo executivo
        IAccounts IApplicantModel.AccountProcessor { get; set; } = new ExecutiveAccount();
    }
}
