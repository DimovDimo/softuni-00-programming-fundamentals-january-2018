using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Trian_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var area = CalculateTriangleArea(width, height);
            Console.WriteLine($"{area}");
        }

        static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
