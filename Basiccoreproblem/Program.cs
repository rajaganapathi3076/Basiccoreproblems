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
            Console.WriteLine("Welcome to Even and odd number UC8");
            Console.WriteLine("Enter a number:");
            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int number))
            {
                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

    
}
