//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Liskov_substitution.types_of_employee
//{
//    internal class CEO : Employee
//    {
//        public override void CalculatePerHourRate(int rank)
//        {
//            decimal baseAmount = 150M;

//            Salary = baseAmount * rank;
//        }

//        public override void AssignManager(Employee manager)
//        {
//            base.AssignManager(manager);
//        }

//        public void GeneratePerformanceReview()
//        {
//            //Simulate reviewing a direct report
//            Console.WriteLine("I'm reviewing a direct report's perfomance");
//        }
        
//        public void FireSomeone()
//        {
//            // Simulate firing someone
//            Console.WriteLine("You're Fired!");
//        }
//    }
//}
