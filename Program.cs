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
                int calculationMode = AskForTypeOfCalculation();

                if(calculationMode == NumberCalculator)
                {
                   PerformOneCalculation();
                }
                else
                {
                    PerformDateCalculation();
                }
                Console.ReadLine();
            }
        }

        private static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Calculator");
                AskForTypeOfCalculation();
        }

        private static void PerformOneCalculation()
            {

            string op = OperatorName();
            int numberOfValues = NumberOfCalculations();
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
            Console.WriteLine("{0:N}", result); //converts string format to include commas on large numbers
      
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

        private static int AskForTypeOfCalculation()
        {
            Console.WriteLine("What type of calculator would you like to use: \n 1) Numeric \n 2) Date ");
            int selectCalcType = int.Parse(Console.ReadLine());
            return selectCalcType;
        }

        private static void PerformDateCalculation()
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
