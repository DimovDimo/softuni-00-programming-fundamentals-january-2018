using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static int[] numbers = new int[1];
        static int[] memo = new int[1];
        static int[] next = new int[1];

        static void Main(string[] args)
        {
            numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToArray();
            //memo = new int[numbers.Length];
            //next = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    next[i] = -1;
            //}
            //
            //LIS(0);
            //var lenOfEvreyNum = new List<List<int>>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    lenOfEvreyNum.Add(LenOfEvreyNum(i));
            //}
            //
            //PrintMostLen(lenOfEvreyNum);

            var result = FindLongestIncreasingSubsequence(numbers);
            Console.WriteLine(string.Join(" ", result));
        }

        static void PrintMostLen(List<List<int>> lenOfEvreyNum)
        {
            var bestLenIndex = -1;
            var bestLenCount = -1;
            for (int i = 0; i < lenOfEvreyNum.Count; i++)
            {
                var currentLen = lenOfEvreyNum[i].Count;
                if (bestLenCount < currentLen)
                {
                    bestLenCount = currentLen;
                    bestLenIndex = i;
                }
            }

            Console.WriteLine(string.Join(" ", 
                lenOfEvreyNum[bestLenIndex]));
        }

        static List<int> LenOfEvreyNum(int index)
        {
            var lenOfEvreyNum = new List<int>();
            while (next[index] != -1)
            {
                lenOfEvreyNum.Add(numbers[index]);
                index = next[index];
            }

            lenOfEvreyNum.Add(numbers[index]);
            return lenOfEvreyNum;
        }
        
        static int LIS(int index)
        {
            if (memo[index] != 0)
            {
                return memo[index];
            }

            int maxLen = 1;
            for (int i = index + 1; i < numbers.Length; i++)
            {
                if (numbers[index] < numbers[i])
                {
                    int len = LIS(i);
                    if (len >= maxLen)
                    {
                        maxLen = len + 1;
                        next[index] = i;
                    }
                }
            }

            memo[index] = maxLen;
            return maxLen;
        }

        // from https://github.com/Innos/Soft-Uni-Excercises/blob/master/Algorithms/04DynamicProgramming/04DynamicProgramming/Longest-Increasing-Subsequence/LongestIncreasingSubsequence.cs
        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            var length = new int[sequence.Length];
            var prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;
            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] + 1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        prev[i] = j;
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            var list = new List<int>();
            while (lastIndex != -1)
            {
                list.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            list.Reverse();
            return list.ToArray();
        }
    }
}
