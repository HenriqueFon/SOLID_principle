using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Single_Responsability
{
    internal class StandardMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void AskNameMessage(string name)
        {
            Console.Write($"What is your {name}:");
        }

        public static void AskNameMessageError(string nameData)
        {
            Console.WriteLine($"You did not give us a valid {nameData}!");
        }

        public static void EndApplication()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
