using System;
using System.IO;

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
                do
                {
                  Console.Write("Please enter number " + (i + 1) + ": ");
                } while (!int.TryParse(Console.ReadLine(), out numbersInput[i]));  
            
            }

            try
            {
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

                string path = @"C:\Users\Sam Egger\source\repos\test.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(result);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You must enter a number greater than 0");
            }
        }        
    
        public static string OperatorName()
        {
            bool validOp = true;
            string op ="";
            while (validOp)
            {
                Console.WriteLine("Please enter the mathmatical operator: ");
                string opp = Console.ReadLine();

                if (opp == "+" || opp == "-" || opp == "*" || opp == "/")
                {
                    op = opp;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry " + opp + " is not an acceptable operator");
                    opp = Console.ReadLine();
                }
            }
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
            int selectCalcType = 0;

            do
            {
              Console.WriteLine("What type of calculator would you like to use: \n 1) Numeric \n 2) Date \n 3) Exit ");
            } while (!int.TryParse(Console.ReadLine(), out selectCalcType));

            return selectCalcType;
        }

    }
}