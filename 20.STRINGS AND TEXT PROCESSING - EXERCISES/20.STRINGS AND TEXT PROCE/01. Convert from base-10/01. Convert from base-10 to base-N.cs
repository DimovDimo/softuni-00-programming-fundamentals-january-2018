using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(BigInteger.Parse)
                .ToList();
            BigInteger system = input[0];
            BigInteger targetNum = input[1];
            var result = new List<BigInteger>();
            while (targetNum > 0)
            {
                var rem = targetNum % system;
                targetNum /= system;
                result.Add(rem);
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
