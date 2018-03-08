using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();
            if (numbers.Length == 1)
            {
                PrintElements(numbers);
            }
            else if (numbers.Length % 2 == 0)
            {
                int[] evenMiddel = new int[2];
                evenMiddel[0] = numbers[numbers.Length / 2 - 1];
                evenMiddel[1] = numbers[numbers.Length / 2];
                PrintElements(evenMiddel);
            }
            else if (numbers.Length % 2 == 1)
            {
                int[] oddMiddel = new int[3];
                oddMiddel[0] = numbers[numbers.Length / 2 - 1];
                oddMiddel[1] = numbers[numbers.Length / 2];
                oddMiddel[2] = numbers[numbers.Length / 2 + 1];
                PrintElements(oddMiddel);
            }
        }

        static void PrintElements(int[] arr)
        {
            Console.WriteLine($"{{ {string.Join(", ", arr)} }}");
        }
    }
}
