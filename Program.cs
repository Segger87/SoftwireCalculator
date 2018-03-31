using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        private const int Exit = 3;
        private const string path = @"C:\Users\Sam Egger\source\repos\test.txt";
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(String.Empty);
            }
            PrintWelcomeMessage();
            while (true)
            {
                int calculationMode = Calculation.AskForTypeOfCalculation();

                if(calculationMode > 3)
                {
                    Console.WriteLine("Sorry " + calculationMode + " is not a valid option");
                }
                else if(calculationMode == NumberCalculator)
                {
                   Calculation.PerformOneCalculation();
                }
                else if(calculationMode == DateCalculator)
                {
                   DateCalculation.PerformDateCalculation();
                }
                else if (calculationMode == Exit)
                {
                    Environment.Exit(0);
                }
                Console.ReadLine();
            }
        }

        private static void PrintWelcomeMessage()
         {
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("================================");
         }
    }
}
