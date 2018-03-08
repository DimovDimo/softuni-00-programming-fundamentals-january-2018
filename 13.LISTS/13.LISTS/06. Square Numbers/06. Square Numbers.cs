using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            numbers.Sort();
            var squareNumbers = new List<double>();
            foreach (var item in numbers)
            {
                var squareRoot = Math.Sqrt(item);
                if (squareRoot % 1 == 0)
                {
                    squareNumbers.Add(item);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
