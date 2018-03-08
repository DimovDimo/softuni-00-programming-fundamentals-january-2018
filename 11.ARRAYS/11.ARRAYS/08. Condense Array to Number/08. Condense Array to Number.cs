using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();
            int[] condensed = new int[numbers.Length - 1];

            if (numbers.Length >= 2)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int i = 0; i < condensed.Length -j; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }

                    numbers = condensed;
                }
                
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
