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
            Console.WriteLine("Welcome to Compute Quotient and Remainder UC6");
            Console.WriteLine("Enter the dividend:");
            string dividendInput = Console.ReadLine();

            Console.WriteLine("Enter the divisor:");
            string divisorInput = Console.ReadLine();

            if (int.TryParse(dividendInput, out int dividend) && int.TryParse(divisorInput, out int divisor))
            {
                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine($"Quotient: {quotient}");
                Console.WriteLine($"Remainder: {remainder}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter integers for both dividend and divisor.");
            }
        }

    }
}
