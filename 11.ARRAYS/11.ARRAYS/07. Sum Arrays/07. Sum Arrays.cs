using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();
            int[] secondArr = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();

            int[] firstArrNew = new int[secondArr.Length];
            int[] secondArrNew = new int[firstArr.Length];
            if (firstArr.Length > secondArr.Length)
            {
                int temporalIndex = 0;
                for (int i = 0; i < secondArrNew.Length; i++)
                {
                    secondArrNew[i] = secondArr[temporalIndex];
                    temporalIndex++;
                    if (temporalIndex > secondArr.Length - 1)
                    {
                        temporalIndex = 0;
                    }
                }
                PrintSumArrays(firstArr, secondArrNew);
            }
            else if (firstArr.Length < secondArr.Length)
            {
                int temporalIndex = 0;
                for (int i = 0; i < firstArrNew.Length; i++)
                {
                    firstArrNew[i] = firstArr[temporalIndex];
                    temporalIndex++;
                    if (temporalIndex > firstArr.Length - 1)
                    {
                        temporalIndex = 0;
                    }
                }
                PrintSumArrays(secondArr, firstArrNew);
            }
            else
            {
                PrintSumArrays(firstArr, secondArr);
            }
        }

        static void PrintSumArrays(int[] arr1, int[] arr2)
        {
            int needLenght = Math.Max(arr1.Length, arr2.Length);
            int[] result = new int[needLenght];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
