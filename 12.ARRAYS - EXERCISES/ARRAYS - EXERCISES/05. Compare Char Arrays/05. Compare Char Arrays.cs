using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().Replace(" ", "");
            string second = Console.ReadLine().Replace(" ", "");
            int minLenght = Math.Min(first.Length, second.Length);
            for (int i = 0; i < minLenght; i++)
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                    return;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                    return;
                }
            }

            if (first.Length <= second.Length)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(second);
                Console.WriteLine(first);
            }
        }
    }
}
