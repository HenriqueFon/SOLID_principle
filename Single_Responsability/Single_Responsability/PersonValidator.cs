using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    internal class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.first_name))
            {
                StandardMessage.AskNameMessageError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.last_name))
            {
                StandardMessage.AskNameMessageError("last name");
                return false;
            }

            return true;
        }
    }
}
