using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nOddNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var oddNum = -1;

            for (int i = 0; i < nOddNumber; i++)
            {
                oddNum += 2;
                Console.WriteLine(oddNum);
                sum += oddNum;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
