using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float heigth = float.Parse(Console.ReadLine());
            float area = width * heigth;

            Console.WriteLine($"{area:F2}");
        }
    }
}
