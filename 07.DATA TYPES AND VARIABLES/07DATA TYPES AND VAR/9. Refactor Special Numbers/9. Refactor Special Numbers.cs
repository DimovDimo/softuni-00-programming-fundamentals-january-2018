using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int reange = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= reange; currentNumber++)
            {
                int numForSumOfDigits = currentNumber;
                int sum = 0;
                while (numForSumOfDigits > 0)
                {
                    sum += numForSumOfDigits % 10;
                    numForSumOfDigits = numForSumOfDigits / 10;
                }
                bool isItSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isItSpecial}");
            }
        }
    }
}
