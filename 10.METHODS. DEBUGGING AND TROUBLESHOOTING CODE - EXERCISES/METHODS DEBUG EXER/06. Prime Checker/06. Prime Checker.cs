using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long currentNumber)
        {
            bool isPrimeNumber = true;
            if (currentNumber > 1)
            {
                for (long currentNumberForDiff = 2; currentNumberForDiff <= Math.Sqrt(currentNumber); currentNumberForDiff++)
                {
                    if (currentNumber % currentNumberForDiff == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
            }
            else
            {
                isPrimeNumber = false;
            }

            return isPrimeNumber;
        }
    }
}
