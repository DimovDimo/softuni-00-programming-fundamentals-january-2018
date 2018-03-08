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
            var startMultiplication = int.Parse(Console.ReadLine());

            if (startMultiplication < 10)
            {
                for (int times = startMultiplication; times <= 10; times++)
                {
                    var product = numberForMultiplication * times;
                    Console.WriteLine($"{numberForMultiplication} X {times} = {product}");
                }
            }
            else
            {
                var product = numberForMultiplication * startMultiplication;
                Console.WriteLine($"{numberForMultiplication} X {startMultiplication} = {product}");
            }
        }
    }
}
