using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            int rotateCount = int.Parse(Console.ReadLine());
            long[] firstRotate = ArrayShiftRight(firstArr);
            long[] sumArr = new long[firstArr.Length];
            long[] lastRotate = new long[firstArr.Length];
            for (int i = 1; i < rotateCount; i++)
            {
                if (i == 1)
                {
                    long[] arrRotated = ArrayShiftRight(firstRotate);
                    sumArr = GetSumOfArrs(firstRotate, arrRotated);
                    lastRotate = arrRotated;
                }
                else
                {
                    long[] arrRotated = ArrayShiftRight(lastRotate);
                    sumArr = GetSumOfArrs(sumArr, arrRotated);
                    lastRotate = arrRotated;
                }
            }

            if (rotateCount == 1)
            {
                sumArr = firstRotate;
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }

        static long[] ArrayShiftRight(long[] array)
        {
            long lastItem = array[array.Length - 1];
            long[] arrNew = new long[array.Length];
            for (long i = array.Length - 1; i >= 1; i--)
            {
                arrNew[i] = array[i - 1];
            }

            arrNew[0] = lastItem;
            return arrNew;
        }

        static long[] GetNewArr(long[] array)
        {
            long[] arrNew = new long[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrNew[i] = array[i];
            }
            return arrNew;
        }

        static long[] GetSumOfArrs(long[] arrayFirst, long[] arraySecond)
        {
            long[] arrSum = new long[arrayFirst.Length];
            for (int i = 0; i < arrayFirst.Length; i++)
            {
                arrSum[i] = arrayFirst[i] + arraySecond[i];
            }
            return arrSum;
        }
    }
}
