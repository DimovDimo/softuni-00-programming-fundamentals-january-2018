using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Aver
{
    class Program
    {
        static void Main(string[] args)
        {
            var countInputs = int.Parse(Console.ReadLine());
            var numbers = new int[countInputs];
            for (int i = 0; i < countInputs; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Sum = 72
            //Min = -5
            //Max = 37
            //Average = 14.4

            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
