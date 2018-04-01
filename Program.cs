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

                switch (calculationMode)
                {
                    case 1:
                        Calculation.PerformOneCalculation();
                        break;
                    case 2:
                        DateCalculation.PerformDateCalculation();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry " + calculationMode + " is not a valid option");
                        break;
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
