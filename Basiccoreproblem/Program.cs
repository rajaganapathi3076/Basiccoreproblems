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
            Console.WriteLine("Welcome to hormonic number UC4");
            Console.WriteLine("Enter the value of n:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n))
            {
                if (n > 0)
                {
                    Console.WriteLine("Harmonic Numbers:");

                    for (int i = 1; i <= n; i++)
                    {
                        double harmonicNumber = CalculateHarmonicNumber(i);
                        Console.WriteLine($"H{i} = {harmonicNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. n should be a positive integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        static double CalculateHarmonicNumber(int n)
        {
            double harmonicNumber = 0.0;

            for (int i = 1; i <= n; i++)
            {
                harmonicNumber += 1.0 / i;
            }

            return harmonicNumber;
        }
    }
    
}
