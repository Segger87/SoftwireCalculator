using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DateCalculation
    {
        public static void PerformDateCalculation()
        {
            DateTime userDate;
            do
            {
                Console.WriteLine("Please Enter a Date: ");
            } while (!DateTime.TryParse(Console.ReadLine(), out userDate));
            {
                Console.WriteLine("Please enter hwo many days you wish to add: ");
                int daysToAdd = int.Parse(Console.ReadLine());
                userDate = userDate.AddDays(daysToAdd);
                Console.WriteLine(userDate.ToLongDateString());
            }
        }
    }
}
