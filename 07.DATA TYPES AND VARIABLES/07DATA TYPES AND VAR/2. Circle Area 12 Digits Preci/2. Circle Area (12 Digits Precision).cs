using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle_Area_12_Digits_Preci
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var circleArea = Math.PI * radius * radius;
            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
