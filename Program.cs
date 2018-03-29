using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                PrintWelcomeMessage();
                string op = OperatorName();
                int numberOfValues = NumberOfCalculations();
                int i = PerformOneCalculation(op, numberOfValues);

                Console.ReadLine();
            }
        }

        private static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Calculator");
            }

        private static int PerformOneCalculation(string op, int numberOfValues)
            {
        
            int[] numbersInput = new int[numberOfValues];
         
            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write("Please enter number " + (i + 1) + ": ");
                numbersInput[i] = int.Parse(Console.ReadLine());
            }

            int result = numbersInput[0];

            for (int i = 1; i < numbersInput.Length; i++)
            {
                if (op == "+")
                {
                    result = result + numbersInput[i];
                }
                else if (op == "-")
                {
                    result = result - numbersInput[i];
                }
                else if (op == "*")
                {
                    result = result * numbersInput[i];
                }
                else if (op == "/")
                {
                    result = result / numbersInput[i];
                }
            }
            Console.WriteLine("The answer is: " + result);
            return result;
        }
        private static string OperatorName()
        {
            Console.WriteLine("Please enter the mathmatical operator: ");
            string op = Console.ReadLine();
            return op;
        }

        private static int NumberOfCalculations()
        {
            int numberOfValues = 0;

        do
        {
            Console.WriteLine("Please enter how many numbers you wish to calculate: ");
        } while (!int.TryParse(Console.ReadLine(), out numberOfValues));

           return numberOfValues;
        }
    }
}
