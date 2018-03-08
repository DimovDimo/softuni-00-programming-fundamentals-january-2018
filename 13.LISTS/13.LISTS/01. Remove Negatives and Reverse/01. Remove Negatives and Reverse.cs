using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var numPositiveAndReversed = new List<int>();
            for (int i = number.Count - 1; i >= 0; i--)
            {
                if (number[i] > 0)//>=
                {
                    numPositiveAndReversed.Add(number[i]);
                }
            }

            if (numPositiveAndReversed.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numPositiveAndReversed));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
