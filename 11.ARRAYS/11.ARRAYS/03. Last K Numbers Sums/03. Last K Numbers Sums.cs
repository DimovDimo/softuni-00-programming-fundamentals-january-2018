using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    if (i - j >= 0)
                    {
                        arr[i] += arr[i - j];
                    }
                }

                Console.Write(arr[i] + " ");
            }
        }
    }
}
