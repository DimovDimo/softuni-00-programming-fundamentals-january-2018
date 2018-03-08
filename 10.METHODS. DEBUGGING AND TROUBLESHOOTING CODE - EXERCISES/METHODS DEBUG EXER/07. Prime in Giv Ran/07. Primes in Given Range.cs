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
            var numberStart = int.Parse(Console.ReadLine());
            var numberFinish = int.Parse(Console.ReadLine());
            var outputString = FindPrimesInRange(numberStart, numberFinish);
            Console.WriteLine(outputString);
        }

        static string FindPrimesInRange(int startNum, int endNum)
        {
            var listWithPrimeNumbers = new List<int>();
            if (startNum <= 2)
            {
                startNum = 2;
            }

            for (int currentNumber = startNum; currentNumber <= endNum; currentNumber++)
            {
                bool isPrimeNumber = true;
                for (int currentNumberForDiff = 2; currentNumberForDiff <= Math.Sqrt(currentNumber); currentNumberForDiff++)
                {
                    if (currentNumber % currentNumberForDiff == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    listWithPrimeNumbers.Add(currentNumber);
                }
            }

            return string.Join(", ", listWithPrimeNumbers);
        }
    }
}
