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
                int daysToAdd = 0;
                do
                {
                  Console.WriteLine("Please enter how many days you wish to add: ");
                } while (!int.TryParse(Console.ReadLine(),out daysToAdd));
                
                userDate = userDate.AddDays(daysToAdd);
                Console.WriteLine(userDate.ToLongDateString());
            }
        }
    }
}
