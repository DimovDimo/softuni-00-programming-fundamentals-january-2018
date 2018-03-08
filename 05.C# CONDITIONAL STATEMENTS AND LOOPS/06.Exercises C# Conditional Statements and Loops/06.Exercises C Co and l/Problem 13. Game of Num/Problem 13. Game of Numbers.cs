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
            var magicalNum = int.Parse(Console.ReadLine());
            var combinations = 0;
            var lastFirst = 0;
            var lastSecond = 0;
            var numFound = false;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    combinations++;
                    if (i + j == magicalNum)
                    {
                        lastFirst = i;
                        lastSecond = j;
                        numFound = true;
                    }
                }
            }
            
            if (numFound)
            {
                Console.WriteLine($"Number found! {lastFirst} + {lastSecond} = {magicalNum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNum}");
            }
        }
    }
}
