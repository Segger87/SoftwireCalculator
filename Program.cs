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
            Console.WriteLine("Welcome to the Calculator");

            Console.WriteLine("Please enter the mathmatical operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Please enter how many numbers you wish to calculate: ");
            int numberOfValues = int.Parse(Console.ReadLine());

            int[] numbersInput = new int[numberOfValues];

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write("Please enter number " + (i + 1) + ": ");
                numbersInput[i] = int.Parse(Console.ReadLine());
            }

            int result = numbersInput[0];

            for (int i = 0; i < numberOfValues; i++)
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
                Console.ReadLine();
        }
    }
}
