using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                //.Select(BigInteger.Parse)
                .ToList();
            var system = BigInteger.Parse(input[0]);
            var targetNums = input[1]
                .ToCharArray()
                .Reverse()
                .Select(x => x.ToString())
                .Select(BigInteger.Parse)
                .ToList();
            var numsForSum = new List<BigInteger>();
            for (int i = 0; i < targetNums.Count; i++)
            {
                numsForSum.Add(BigInteger.Multiply(targetNums[i], BigInteger.Pow(system, i)));
            }

            BigInteger sum = 0;
            foreach (var item in numsForSum)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
