using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Numb
{
    class Program
    {
        static void Main(string[] args)
        {
            int sing = int.Parse(Console.ReadLine());
            PrintSing(sing);
        }

        static void PrintSing(int sing)
        {
            string singOfInt = "";
            if (sing > 0)
            {
                singOfInt = "positive";
            }
            else if (sing == 0)
            {
                singOfInt = "zero";
            }
            else
            {
                singOfInt = "negative";
            }
            PrintSingOsInt(sing, singOfInt);
        }

        static void PrintSingOsInt(int sing, string singOfInt)
        {
            Console.WriteLine($"The number {sing} is {singOfInt}.");
        }
    }
}
