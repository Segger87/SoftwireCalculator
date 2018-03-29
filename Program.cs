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
        private const string path = @"C:\Users\Sam Egger\source\repos\test.txt";
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Flush();
                sw.Write(String.Empty);
            }
            while (true)
            {
                int calculationMode = Calculation.AskForTypeOfCalculation();

                if(calculationMode > 2)
                {
                  PrintWelcomeMessage();
                }
                else if(calculationMode == NumberCalculator)
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
