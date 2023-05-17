using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiccoreproblem
{
    internal class Program
    {
        static bool IsPowerOfTwo(int number)
        {
            
            if (number <= 0)
            {
                return false; // Numbers less than or equal to 0 are not powers of 2
            }

            return (number & (number - 1)) == 0;
        }

        static void Main()
        {
            Console.WriteLine("Welcome to power of two UC3");
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                bool isPowerOfTwo = IsPowerOfTwo(number);

                if (isPowerOfTwo)
                {
                    Console.WriteLine($"{number} is a power of 2.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a power of 2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}
