using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter = char.Parse(Console.ReadLine());

            if (Char.IsDigit(letter))
            {
                Console.WriteLine("digit");
            }
            else if (letter == 'a' || letter == 'e' || letter == 'i' ||
                letter == 'o' || letter == 'u' || letter == 'y') //a, e, i, o, u, and sometimes y
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
