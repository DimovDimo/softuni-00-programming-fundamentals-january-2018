using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var theInteger = int.Parse(Console.ReadLine());
                if (Math.Abs(theInteger)%2 != 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(theInteger)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }

            } while (true);
        }
    }
}
