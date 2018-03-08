using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfElement = int.Parse(Console.ReadLine());
            var arr = new int[countOfElement];
            for (int i = 0; i <= countOfElement - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = countOfElement - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
