using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool[] boolNums = new bool[number + 1];
            for (int i = 0; i < boolNums.Length; i++)
            {
                boolNums[i] = true;
            }

            boolNums[0] = false;
            boolNums[1] = false;

            for (int i = 0; i < boolNums.Length; i++)
            {
                if (boolNums[i])
                {
                    Console.Write(i + " ");
                    for (int j = i; j < boolNums.Length; j++)
                    {
                        if (j % i == 0)
                        {
                            boolNums[j] = false;
                        }
                    }
                }
            }
        }
    }
}
