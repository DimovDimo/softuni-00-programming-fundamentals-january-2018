using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            var numberOfPower = NumberOfPower(number, power);
            Console.WriteLine($"{numberOfPower}");
        }

        static double NumberOfPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
