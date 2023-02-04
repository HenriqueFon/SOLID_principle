using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        IAccounts IApplicantModel.AccountProcessor { get; set; } = new ManagerAccounts();   
    }
}
