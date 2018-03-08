using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFibonachi = ulong.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonachiNumber(numberOfFibonachi));
        }

        static ulong GetFibonachiNumber(ulong numberOfFibonachi)
        {
            if (numberOfFibonachi < 2)
            {
                return 1;
            }
            else
            {
                ulong fibNumFirst = 1;
                ulong fibNumSecond = 1;
                for (ulong i = 2; i <= numberOfFibonachi; i++)
                {
                    var tamporalNum = fibNumSecond;
                    fibNumSecond = fibNumFirst + fibNumSecond;
                    fibNumFirst = tamporalNum;
                }
                return fibNumSecond;
            }
        }
    }
}
