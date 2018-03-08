using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Inte_of_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNum, secondNum); i <= Math.Max(firstNum, secondNum); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
