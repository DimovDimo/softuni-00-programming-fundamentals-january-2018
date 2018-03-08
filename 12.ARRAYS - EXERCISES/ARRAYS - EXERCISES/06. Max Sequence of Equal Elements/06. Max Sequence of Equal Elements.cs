using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int bestStart = 0;
            int bestLen = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                int curentStart = 0;
                int curenLen = 0;
                for (int j = i; j < firstArr.Length; j++)
                {
                    if (firstArr.Length - 1 >= j + 1)
                    {
                        if (firstArr[j] == firstArr[j + 1])
                        {
                            curentStart = firstArr[j];
                            curenLen++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (bestLen < curenLen)
                {
                    bestStart = curentStart;
                    bestLen = curenLen;
                }              
            }

            for (int i = 0; i <= bestLen; i++)
            {
                Console.Write(bestStart + " ");
            }
        }
    }
}
