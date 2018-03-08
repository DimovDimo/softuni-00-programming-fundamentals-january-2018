using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sing = int.Parse(Console.ReadLine());
            PrintUpTriangel(sing);
            PrintDownTriangel(sing);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintUpTriangel(int end)
        {
            for (int i = 0; i < end; i++)
            {
                PrintLine(1, i);
            }
        }

        static void PrintDownTriangel(int end)
        {
            for (int i = end; i >= 0d; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
