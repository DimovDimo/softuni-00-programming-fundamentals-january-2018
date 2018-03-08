using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Tria_of_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleRows; i++)
            {
                for (int num = 0; num < i; num++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
