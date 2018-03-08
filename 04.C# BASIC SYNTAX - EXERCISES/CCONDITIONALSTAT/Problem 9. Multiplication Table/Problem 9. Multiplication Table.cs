using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberForMultiplication = int.Parse(Console.ReadLine());
            for (int times = 1; times <= 10; times++)
            {
                var product = numberForMultiplication*times;
                Console.WriteLine($"{numberForMultiplication} X {times} = {product}");
            }
        }
    }
}
