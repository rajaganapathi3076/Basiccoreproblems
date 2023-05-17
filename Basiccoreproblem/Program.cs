using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiccoreproblem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Checking large number UC10");
            Console.WriteLine("Enter the first number:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string secondNumberInput = Console.ReadLine();

            Console.WriteLine("Enter the third number:");
            string thirdNumberInput = Console.ReadLine();

            if (int.TryParse(firstNumberInput, out int firstNumber) &&
                int.TryParse(secondNumberInput, out int secondNumber) &&
                int.TryParse(thirdNumberInput, out int thirdNumber))
            {
                int largestNumber = FindLargestNumber(firstNumber, secondNumber, thirdNumber);
                Console.WriteLine($"The largest number among {firstNumber}, {secondNumber}, and {thirdNumber} is: {largestNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter integers for all three numbers.");
            }
        }

        static int FindLargestNumber(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }

    
}
