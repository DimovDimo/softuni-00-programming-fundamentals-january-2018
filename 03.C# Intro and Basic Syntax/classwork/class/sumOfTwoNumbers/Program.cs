using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sum = furstNum + secondNum;
            Console.WriteLine("{0} + {1} = {2}", furstNum, secondNum, sum);
        }
    }
}
