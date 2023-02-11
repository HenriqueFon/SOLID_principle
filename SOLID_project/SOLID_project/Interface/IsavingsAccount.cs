using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_project.Interface
{
    public interface IsavingsAccount
    {
        decimal InterestRate { get; set; }
        decimal CalculateInterest();
    }
}
