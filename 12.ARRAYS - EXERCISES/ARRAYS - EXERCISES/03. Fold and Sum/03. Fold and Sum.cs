using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            long[] arrFirstQater = GetFirstQater(firstArr);
            long[] arrLastQater = GetLastQater(firstArr);
            Array.Reverse(arrFirstQater);
            Array.Reverse(arrLastQater);
            long[] arrFromQaters = arrFirstQater.Concat(arrLastQater).ToArray();
            long[] arrMiddelQaters = GetMiddelQaters(firstArr);
            long[] sumArrs = GetSumOfArrs(arrFromQaters, arrMiddelQaters);
            Console.WriteLine(string.Join(" ", sumArrs));
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

        static long[] GetFirstQater(long[] arr)
        {
            long[] arrFirstQater = new long[arr.Length / 4];
            for (int i = 0; i < arr.Length / 4.0; i++)
            {
                arrFirstQater[i] = arr[i];
            }
            return arrFirstQater;
        }

        static long[] GetLastQater(long[] arr)
        {
            long[] arrLastQater = new long[arr.Length / 4];
            int start = (int)(arr.Length / 4.0) * 3;
            int end = start + arr.Length / 4;
            for (int i = start; i < end; i++)
            {
                arrLastQater[i - start] = arr[i];
            }
            return arrLastQater;
        }

        static long[] GetMiddelQaters(long[] arr)
        {
            long[] arrMiddelQaters = new long[arr.Length / 2];
            int start = (int)(arr.Length / 4.0);
            int end = start * 3;
            for (int i = start; i < end; i++)
            {
                arrMiddelQaters[i - start] = arr[i];
            }
            return arrMiddelQaters;
        }
    }
}
