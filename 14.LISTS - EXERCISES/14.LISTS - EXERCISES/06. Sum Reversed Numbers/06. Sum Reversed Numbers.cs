using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersAsString = Console.ReadLine()
                .Split(' ')
                .ToList();
            var numbersAsStringReversed = new List<string>(); // long or double
            foreach (var item in numbersAsString)
            {
                numbersAsStringReversed.Add(ReverseString(item));
            }

            var sum = 0;
            foreach (var item in numbersAsStringReversed)
            {
                sum += int.Parse(item);
            }

            Console.WriteLine(sum);
        }

        static string ReverseString(string inpudString)
        {
            char[] charArray = inpudString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
