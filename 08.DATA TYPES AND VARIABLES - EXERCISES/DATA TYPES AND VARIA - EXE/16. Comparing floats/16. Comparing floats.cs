using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal secondNumber = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal difference = Math.Abs(firstNumber - secondNumber);
            bool isDifferenceLess = difference < 0.000001m;
            Console.WriteLine(isDifferenceLess);
        }
    }
}
