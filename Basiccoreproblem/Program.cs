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
            Console.WriteLine("Welcome to Swap number UC7");
            Console.WriteLine("Enter the first number:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string secondNumberInput = Console.ReadLine();

            if (int.TryParse(firstNumberInput, out int firstNumber) && int.TryParse(secondNumberInput, out int secondNumber))
            {
                Console.WriteLine($"Before swapping: First Number = {firstNumber}, Second Number = {secondNumber}");


                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;

                Console.WriteLine($"After swapping: First Number = {firstNumber}, Second Number = {secondNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter integers for both numbers.");
            }
        }

    }
}
