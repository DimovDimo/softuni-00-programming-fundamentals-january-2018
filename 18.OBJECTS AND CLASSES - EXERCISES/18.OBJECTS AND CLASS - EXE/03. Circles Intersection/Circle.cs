using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        static public Circle ReadCircle()
        {
            var separated = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            return new Circle
            {
                X = separated[0],
                Y = separated[1],
                Radius = separated[2]
            };
        }

        static public bool Intersect(Circle c1, Circle c2)
        {
            var distance = Point.CalcDistance(c1, c2);
            var sumOfRadiuses = c1.Radius + c2.Radius;
            if (distance <= sumOfRadiuses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
