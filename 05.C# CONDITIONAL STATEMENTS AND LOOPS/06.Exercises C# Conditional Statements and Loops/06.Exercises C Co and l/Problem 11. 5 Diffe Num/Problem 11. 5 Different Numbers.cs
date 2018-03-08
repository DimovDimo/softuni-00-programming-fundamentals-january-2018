using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11._5_Diffe_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            var n1 = firstNum + 0;
            var n2 = firstNum + 1;
            var n3 = firstNum + 2;
            var n4 = firstNum + 3;
            var n5 = firstNum + 4;

            var n1last = secondNum - 4;
            var n2last = secondNum - 3;
            var n3last = secondNum - 2;
            var n4last = secondNum - 1;
            var n5last = secondNum - 0;

            if (n5 > secondNum)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = n1; i <= n1last; i++)
                {
                    for (int j = n2; j <= n2last; j++)
                    {
                        for (int k = n3; k <= n3last; k++)
                        {
                            for (int p = n4; p <= n4last; p++)
                            {
                                for (int t = n5; t <= n5last; t++)
                                {
                                    if (i < j && j < k && k < p && p < t)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {p} {t}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
