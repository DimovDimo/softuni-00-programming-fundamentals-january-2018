using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Cou_the_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            var countNum = 0;
            bool temporalIntTryParse = true;

            do
            {
                int number;
                temporalIntTryParse = int.TryParse(Console.ReadLine(), out number);
                if (temporalIntTryParse)
                {
                    countNum++;
                }

            } while (temporalIntTryParse);

            Console.WriteLine(countNum);
        }
    }
}
