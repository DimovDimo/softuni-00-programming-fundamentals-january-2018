using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        static public double CalcDistance(Point p1, Point p2)
        {
            var sideA = Math.Pow(p1.X - p2.X, 2);
            var sideB = Math.Pow(p1.Y - p2.Y, 2);
            return Math.Sqrt(sideA + sideB);
        }
    }
}
