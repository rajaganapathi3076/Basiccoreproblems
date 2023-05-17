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
            Console.WriteLine("Welcome to Alphabet is Vowel or Consonant UC9");
            Console.WriteLine("Enter an alphabet:");
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                char alphabet = char.ToLower(input[0]);

                if (IsAlphabet(alphabet))
                {
                    if (IsVowel(alphabet))
                    {
                        Console.WriteLine($"{alphabet} is a vowel.");
                    }
                    else
                    {
                        Console.WriteLine($"{alphabet} is a consonant.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid alphabet.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a single alphabet.");
            }
        }

        static bool IsAlphabet(char character)
        {
            return char.IsLetter(character);
        }

        static bool IsVowel(char alphabet)
        {
            alphabet = char.ToLower(alphabet);

            return alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u';
        }
    }

    
}
