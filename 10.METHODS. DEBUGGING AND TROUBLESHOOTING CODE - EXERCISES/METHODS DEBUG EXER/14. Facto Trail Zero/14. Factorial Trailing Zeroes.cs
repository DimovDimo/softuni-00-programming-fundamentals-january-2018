using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Facto_Trail_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger nFactorial = BigInteger.Parse(Console.ReadLine());
            var factorial = GetFactorial(nFactorial);
            var zeroes = GetLastZeroes(factorial);
            Console.WriteLine(zeroes);
        }

        static BigInteger GetFactorial(BigInteger nFactorial)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= nFactorial; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static BigInteger GetLastZeroes(BigInteger factorial)
        {
            BigInteger zeroes = 0;
            while (factorial > 0)
            {
                var lastDigit = factorial % 10;
                if (lastDigit == 0)
                {
                    zeroes++;
                }
                else
                {
                    return zeroes;
                }
                factorial /= 10;
            }
            return zeroes;
        }
    }
}
