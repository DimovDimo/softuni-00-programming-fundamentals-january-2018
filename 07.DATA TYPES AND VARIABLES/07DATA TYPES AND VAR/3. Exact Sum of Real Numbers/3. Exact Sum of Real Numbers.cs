using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{sum}");
        }
    }
}
