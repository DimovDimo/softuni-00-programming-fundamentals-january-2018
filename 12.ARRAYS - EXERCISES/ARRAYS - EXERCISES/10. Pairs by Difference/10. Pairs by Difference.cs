using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int countPairs = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = i; j < firstArr.Length; j++)
                {
                    if (Math.Abs(firstArr[i] - firstArr[j]) == difference)
                    {
                        countPairs++;
                    }
                }
            }

            Console.WriteLine(countPairs);
        }
    }
}
