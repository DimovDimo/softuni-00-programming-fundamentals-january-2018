using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var afterRound = doubleArr
                .Select(s => Math.Round(s, 0, MidpointRounding.AwayFromZero))
                .ToArray();

            for (int i = 0; i < doubleArr.Length; i++)
            {
                Console.WriteLine($"{doubleArr[i]} => {afterRound[i]}");
            }
        }
    }
}
