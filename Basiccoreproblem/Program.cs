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
            Console.WriteLine("Welcome to Leap year problem UC2");
            Console.WriteLine("Enter the number of  x:");
            int year = Convert.ToInt32(Console.ReadLine());



            if (((year % 4 == 0) && ((year % 400 == 0) || (year % 100 != 0))))
            {
                Console.WriteLine("This is leap year");

            }
            else
            {
                Console.WriteLine("This is not leap year");
            }
            Console.ReadLine();
        }
    }
}
