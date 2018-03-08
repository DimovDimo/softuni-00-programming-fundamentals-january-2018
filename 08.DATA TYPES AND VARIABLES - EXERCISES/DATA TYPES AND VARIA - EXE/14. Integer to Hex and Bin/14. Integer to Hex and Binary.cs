using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(decimalNumber, 16).ToUpper());//hexadecimal
            Console.WriteLine(Convert.ToString(decimalNumber, 2));//binary
        }
    }
}
