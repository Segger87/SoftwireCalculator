using System;

namespace Calculator
{
    class Calculation
    {
        public static void PerformOneCalculation()
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
        public static string OperatorName()
        {
            Console.WriteLine("Please enter the mathmatical operator: ");
            string op = Console.ReadLine();
            return op;
        }

        public static int NumberOfCalculations()
        {
            int numberOfValues = 0;

            do
            {
                Console.WriteLine("Please enter how many numbers you wish to calculate: ");
            } while (!int.TryParse(Console.ReadLine(), out numberOfValues));

            return numberOfValues;
        }

        public static int AskForTypeOfCalculation()
        {
            Console.WriteLine("What type of calculator would you like to use: \n 1) Numeric \n 2) Date ");
            int selectCalcType = int.Parse(Console.ReadLine());
            return selectCalcType;
        }

    }
}