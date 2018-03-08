using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int sing = int.Parse(Console.ReadLine());
            PrintTopAndBottom(sing);
            PrintMiddleRows(sing);
            PrintTopAndBottom(sing);
        }

        static void PrintTopAndBottom(int sings)
        {
            Console.WriteLine(new String('-', sings*2));
        }

        static void PrintMiddleRows(int sings)
        {
            for (int i = 0; i < sings - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < sings-1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
