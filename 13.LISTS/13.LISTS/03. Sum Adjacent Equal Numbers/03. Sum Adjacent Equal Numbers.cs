using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count > i+1)
                {
                    if (numbers[i + 1] == numbers[i])
                    {
                        numbers[i +1] += numbers[i];
                        numbers.RemoveAt(i);
                        i = -1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
