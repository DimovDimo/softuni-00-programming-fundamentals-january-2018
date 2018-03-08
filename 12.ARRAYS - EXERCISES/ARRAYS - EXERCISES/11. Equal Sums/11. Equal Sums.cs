using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < firstArr.Length; i++)
            {
                int leftSum = GetSumInRangeOfArray(firstArr, 0, i - 1);
                int rightSum = GetSumInRangeOfArray(firstArr, i + 1, firstArr.Length - 1);
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }

        static int GetSumInRangeOfArray(int[] arr, int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        
    }
}
