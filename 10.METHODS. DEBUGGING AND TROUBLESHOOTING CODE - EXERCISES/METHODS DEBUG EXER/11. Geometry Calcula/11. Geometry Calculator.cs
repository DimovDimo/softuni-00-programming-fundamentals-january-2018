using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calcula
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine().ToLower();
            if (figureType == "triangle")
            {
                PrintAreaOfTriangle();
            }
            else if (figureType == "rectangle")
            {
                PrintAreaOfRectangle();
            }
            else if (figureType == "circle")
            {
                PrintAreaOfCircle();
            }
            else if (figureType == "square")
            {
                PrintAreaOfSquaree();
            }
        }

        static void PrintAreaOfTriangle()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = side * height / 2;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintAreaOfSquaree()
        {
            var side = double.Parse(Console.ReadLine());
            var area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintAreaOfRectangle()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintAreaOfCircle()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = radius * radius * Math.PI;
            Console.WriteLine($"{area:F2}");
        }
    }
}
