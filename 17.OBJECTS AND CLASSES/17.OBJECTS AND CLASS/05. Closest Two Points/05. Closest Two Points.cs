using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            Point[] points = new Point[rows];
            for (int i = 0; i < rows; i++)
            {
                var pointCurrent = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
                var pointInClass = new Point { X = pointCurrent[0], Y = pointCurrent[1] };
                points[i] = pointInClass;
            }

            Point.PrintClosestTwoPoints(points);
            //var closestTwoPoints = double.MaxValue;
            //var firstPoint = new Point();
            //var secondPoint = new Point();
            //for (int i = 0; i < points.Length; i++)
            //{
            //    for (int j = i + 1; j < points.Length; j++)
            //    {
            //        var currentDistance = Point.CalcDistance(points[i], points[j]);
            //        if (currentDistance < closestTwoPoints)
            //        {
            //            closestTwoPoints = currentDistance;
            //            firstPoint = points[i];
            //            secondPoint = points[j];
            //        }
            //    }
            //}
            //
            //Console.WriteLine($"{closestTwoPoints:F3}");
            //Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
            //Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
        }
    }

    //class Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }
    //    static public double CalcDistance(Point p1, Point p2)
    //    {
    //        var sideA = Math.Pow(p1.X - p2.X, 2);
    //        var sideB = Math.Pow(p1.Y - p2.Y, 2);
    //        return Math.Sqrt(sideA + sideB);
    //    }
    //
    //    static public void PrintClosestTwoPoints(Point[] points)
    //    {// If arr've got 1 point
    //        var closestTwoPoints = double.MaxValue;
    //        var firstPoint = new Point();
    //        var secondPoint = new Point();
    //        for (int i = 0; i < points.Length; i++)
    //        {
    //            for (int j = i + 1; j < points.Length; j++)
    //            {
    //                var currentDistance = Point.CalcDistance(points[i], points[j]);
    //                if (currentDistance < closestTwoPoints)
    //                {
    //                    closestTwoPoints = currentDistance;
    //                    firstPoint = points[i];
    //                    secondPoint = points[j];
    //                }
    //            }
    //        }
    //
    //        Console.WriteLine($"{closestTwoPoints:F3}");
    //        Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
    //        Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
    //    }
    //}
}
