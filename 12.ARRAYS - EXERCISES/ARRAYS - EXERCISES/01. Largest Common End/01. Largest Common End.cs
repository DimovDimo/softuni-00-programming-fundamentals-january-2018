using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] secondArr = Console.ReadLine()
                .Split(' ')
                .ToArray();
            if (firstArr[0] != secondArr[0]
                && firstArr[firstArr.Length - 1] != secondArr[secondArr.Length - 1])
            {
                int countEqualElements = CountEqualElements(firstArr, secondArr);
                Console.WriteLine(countEqualElements);
            }
            else if (firstArr[0] == secondArr[0]
                && firstArr[firstArr.Length - 1] != secondArr[secondArr.Length - 1])
            {
                int countEqualElements = CountEqualElements(firstArr, secondArr);
                Console.WriteLine(countEqualElements);
            }
            else if (firstArr[0] != secondArr[0]
                && firstArr[firstArr.Length - 1] == secondArr[secondArr.Length - 1])
            {
                Array.Reverse(firstArr);
                Array.Reverse(secondArr);
                int countEqualElements = CountEqualElements(firstArr, secondArr);
                Console.WriteLine(countEqualElements);
            }
            else if (firstArr[0] == secondArr[0]
                && firstArr[firstArr.Length - 1] == secondArr[secondArr.Length - 1])
            {
                int countEqualElementsRightToLeft = CountEqualElements(firstArr, secondArr);
                Array.Reverse(firstArr);
                Array.Reverse(secondArr);
                int countEqualElementsLeftToRight = CountEqualElements(firstArr, secondArr);
                Console.WriteLine(Math.Max(countEqualElementsRightToLeft, countEqualElementsLeftToRight));
            }
        }

        static int CountEqualElements(string[] firstArr, string[] secondArr)
        {
            int countEqualElements = 0;
            int lenghtMin = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < lenghtMin; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    countEqualElements++;
                }
                else
                {
                    break;
                }
            }
            return countEqualElements;
        }
    }
}
