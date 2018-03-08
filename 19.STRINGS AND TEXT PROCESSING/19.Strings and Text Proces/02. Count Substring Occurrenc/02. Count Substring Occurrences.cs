using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrenc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var target = Console.ReadLine().ToLower();
            var counter = 0;
            var indexOfLast = 0;
            while (indexOfLast > -1)
            {
                indexOfLast = text.IndexOf(target, indexOfLast);
                if (indexOfLast > -1)
                {
                    counter++;
                    indexOfLast++;
                    if (indexOfLast > text.Length - 1)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
