using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Num_in_Rev_Order
{
    class Program
    {
        static void Main()
        {
            decimal decimalNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(decimalNum));
        }

        static double ReverseNumber(decimal number)
        {
            return double.Parse(ReverseString(number.ToString()));
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
