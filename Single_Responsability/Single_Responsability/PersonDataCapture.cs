using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    internal class PersonDataCapture
    {
        public static Person CaptureInformation()
        {
            Person output = new Person();

            StandardMessage.AskNameMessage("first name");
            output.first_name = Console.ReadLine();

            StandardMessage.AskNameMessage("last name");
            output.last_name = Console.ReadLine();

            return output;
        }
    }
}
