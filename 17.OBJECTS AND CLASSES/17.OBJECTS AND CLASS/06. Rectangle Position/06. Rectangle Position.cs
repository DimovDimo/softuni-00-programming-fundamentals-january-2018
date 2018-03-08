using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var recFirstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var rectangleFirst = new Rectangle
            {
                Left = recFirstInput[0],
                Top = recFirstInput[1],
                Width = recFirstInput[2],
                Height = recFirstInput[3]
            };

            var recSecondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var rectangleSecond = new Rectangle
            {
                Left = recSecondInput[0],
                Top = recSecondInput[1],
                Width = recSecondInput[2],
                Height = recSecondInput[3]
            };

            Console.WriteLine(rectangleFirst.IsInside(rectangleSecond) ? "Inside" : "Not Inside");
        }
    }
}
