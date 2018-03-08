using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal milesToKilometersConstant = 1.60934m;
            decimal kilometers = miles * milesToKilometersConstant;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
