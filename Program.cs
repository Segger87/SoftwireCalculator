using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        static void Main(string[] args)
        {
            while(true)
            {
                int calculationMode = Calculation.AskForTypeOfCalculation();

                if(calculationMode == NumberCalculator)
                {
                   Calculation.PerformOneCalculation();
                }
                else
                {
                   DateCalculation.PerformDateCalculation();
                }
                Console.ReadLine();
            }
        }

        private static void PrintWelcomeMessage()
         {
            Console.WriteLine("Welcome to the Calculator");
            Calculation.AskForTypeOfCalculation();
         }
    }
}
