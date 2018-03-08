using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();

            var isFound = false;
            if (intArr.Length >= 3)
            {
                for (int i = 0; i < intArr.Length; i++)
                {
                    for (int j = 1; j < intArr.Length; j++)
                    {
                        for (int k = 0; k < intArr.Length; k++)
                        {
                            if (intArr[i] + intArr[j] == intArr[k]
                                && i < j)
                            {
                                isFound = true;
                                Console.WriteLine($"{intArr[i]} + {intArr[j]} == {intArr[k]}");
                                break;
                            }
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
