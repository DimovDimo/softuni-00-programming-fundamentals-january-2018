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
                int curentStart = i;
                int curenLen = 1;
                for (int j = i; j < firstArr.Length; j++)
                {
                    if (j + 1 <= firstArr.Length - 1)
                    {
                        if (firstArr[j] < firstArr[j + 1])
                        {
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

            if (bestLen == 1)
            {
                bestLen = 0;
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(firstArr[i] + " ");
            }
        }
    }
}
