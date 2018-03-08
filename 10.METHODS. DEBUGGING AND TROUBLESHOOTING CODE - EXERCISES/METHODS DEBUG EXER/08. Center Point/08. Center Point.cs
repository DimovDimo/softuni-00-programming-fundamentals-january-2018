using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var distanceOfPoint1 = GetDistanceToTheCenter(x1, y1);
            var distanceOfPoint2 = GetDistanceToTheCenter(x2, y2);

            if (distanceOfPoint1 <= distanceOfPoint2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double GetDistanceToTheCenter(double x, double y)
        {
            return Math.Sqrt(x*x + y*y);
        }
    }
}
