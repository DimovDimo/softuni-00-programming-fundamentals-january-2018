using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircle = Circle.ReadCircle();
            var secondCircle = Circle.ReadCircle();
            Console.WriteLine(Circle.Intersect(firstCircle, secondCircle) ?
                "Yes" : "No");
        }
    }
}
