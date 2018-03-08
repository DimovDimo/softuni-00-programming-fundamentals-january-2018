using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var maximumSum = int.Parse(Console.ReadLine());
            var combinations = 0;
            var curentSum = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    combinations++;
                    curentSum += 3 * (i * j);
                    if (curentSum >= maximumSum)
                    {
                        break;
                    }
                }
                if (curentSum >= maximumSum)
                {
                    break;
                }
            }

            Console.WriteLine($"{combinations} combinations");
            if (curentSum >= maximumSum)
            {
                Console.WriteLine($"Sum: {curentSum} >= {maximumSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {curentSum}");
            }
        }
    }
}
