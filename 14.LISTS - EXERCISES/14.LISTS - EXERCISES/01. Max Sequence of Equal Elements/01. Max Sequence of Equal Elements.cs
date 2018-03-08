using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToList();
            var bestNumber = 0;
            if (numbers.Count != 0)
            {
                bestNumber = numbers[0];
            }

            var bestLen = 1;
            var currentLen = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        currentLen++;
                    }
                    else
                    {
                        if (bestLen < currentLen)
                        {
                            bestNumber = numbers[i];
                            bestLen = currentLen;
                        }

                        currentLen = 1;
                    }
                }
                else
                {
                    if (bestLen < currentLen)
                    {
                        bestNumber = numbers[i];
                        bestLen = currentLen;
                    }
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestNumber + " ");
            }
        }
    }
}
