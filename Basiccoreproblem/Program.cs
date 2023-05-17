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
            Console.WriteLine("Welcome to Prime factor UC4");
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long N))
            {
                Console.WriteLine($"Prime factors of {N}:");
                ComputePrimeFactors(N);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        static void ComputePrimeFactors(long N)
        {
            for (long i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
            }

            if (N > 1)
            {
                Console.WriteLine(N);
            }
        }

    }
}
