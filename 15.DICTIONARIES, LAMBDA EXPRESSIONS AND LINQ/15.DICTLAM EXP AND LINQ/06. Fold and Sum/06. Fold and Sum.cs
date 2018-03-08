using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var firstQater = numbers
                .Take(numbers.Count / 4)
                .Reverse()
                .ToList();
            var lastQater = numbers
                .Skip(numbers.Count / 4 * 3)
                .Take(numbers.Count / 4)
                .Reverse()
                .ToList();
            var firstRow = firstQater
                .Concat(lastQater)
                .ToList(); ;
            var secondRow = numbers
                .Skip(numbers.Count / 4 * 1)
                .Take(numbers.Count / 2)
                .ToList();
            var sum = firstRow
                .Select((x, index) => x + secondRow[index])
                .ToList();
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
