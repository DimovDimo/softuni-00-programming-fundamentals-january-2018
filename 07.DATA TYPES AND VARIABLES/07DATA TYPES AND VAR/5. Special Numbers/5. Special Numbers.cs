using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reange = int.Parse(Console.ReadLine());
            for (int i = 1; i <= reange; i++)
            {
                var sum = 0;
                var tempNum = i;
                do
                {
                    sum += tempNum % 10;
                    tempNum /= 10;
                } while (tempNum != 0);
                var isItSpecialNumber = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{i} -> {isItSpecialNumber}");
            }
        }
    }
}
