using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1A = double.Parse(Console.ReadLine());
            var y1A = double.Parse(Console.ReadLine());
            var x2A = double.Parse(Console.ReadLine());
            var y2A = double.Parse(Console.ReadLine());
            var x1B = double.Parse(Console.ReadLine());
            var y1B = double.Parse(Console.ReadLine());
            var x2B = double.Parse(Console.ReadLine());
            var y2B = double.Parse(Console.ReadLine());
            var lenghtOfLineA = GetDistanceBetweenPoints(x1A, y1A, x2A, y2A);
            var lenghtOfLineB = GetDistanceBetweenPoints(x1B, y1B, x2B, y2B);
            if (lenghtOfLineA >= lenghtOfLineB)
            {
                PrintPointsClosestPointFirst(x1A, y1A, x2A, y2A);
            }
            else
            {
                PrintPointsClosestPointFirst(x1B, y1B, x2B, y2B);
            }
        }

        static double GetDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var sqaerX = Math.Pow(x2 - x1, 2);
            var sqaerY = Math.Pow(y2 - y1, 2);
            return Math.Sqrt(sqaerX + sqaerY);
        }

        static void PrintPointsClosestPointFirst(double x1, double y1, double x2, double y2)
        {
            var distanceOfPoint1 = GetDistanceToTheCenter(x1, y1);
            var distanceOfPoint2 = GetDistanceToTheCenter(x2, y2);

            if (distanceOfPoint1 <= distanceOfPoint2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        static double GetDistanceToTheCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);

        }
    }
}
