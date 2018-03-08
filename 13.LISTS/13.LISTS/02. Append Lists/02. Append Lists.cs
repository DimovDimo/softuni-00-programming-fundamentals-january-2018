using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();
            numbers.Reverse();
            List<string> result = new List<string>();
            foreach (var itemFormNumbers in numbers)
            {
                List<string> preprate = itemFormNumbers
                        .Split(' ')
                        .ToList();
                foreach (var itemFromPreparte in preprate)
                {
                    result.Add(itemFromPreparte);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
