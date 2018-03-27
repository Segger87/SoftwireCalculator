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
            Console.WriteLine("Enter one number: ");

            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");

            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber * secondNumber;

            Console.WriteLine(firstNumber + " X " + secondNumber + " = " + result);
            Console.ReadLine();
        }
    }
}
