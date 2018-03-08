using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger countFactorial = 1;
            var nFactorial = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nFactorial; i++)
            {
                countFactorial *= i;
            }

            Console.WriteLine(countFactorial);
        }
    }
}
