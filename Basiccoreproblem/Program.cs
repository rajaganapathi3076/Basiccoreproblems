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
            Console.WriteLine("Enter the number of times to flip the coin:");
            string input = Console.ReadLine();
            int numberOfFlips;

            if (int.TryParse(input, out numberOfFlips) && numberOfFlips > 0)
            {
                int headsCount = 0;
                int tailsCount = 0;

                Random random = new Random();

                for (int i = 0; i < numberOfFlips; i++)
                {
                    if (random.NextDouble() < 0.5)
                    {
                        tailsCount++;
                    }
                    else
                    {
                        headsCount++;
                    }
                }

                double headsPercentage = (double)headsCount / numberOfFlips * 100;
                double tailsPercentage = (double)tailsCount / numberOfFlips * 100;

                Console.WriteLine($"Heads: {headsCount} ({headsPercentage}%)\nTails: {tailsCount} ({tailsPercentage}%)");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
