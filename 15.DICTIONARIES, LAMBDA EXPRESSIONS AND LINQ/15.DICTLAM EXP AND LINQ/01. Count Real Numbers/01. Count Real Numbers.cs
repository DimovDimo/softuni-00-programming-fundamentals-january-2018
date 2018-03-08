using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDoubleList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var dictionary = new SortedDictionary<double, int>();
            foreach (var word in inputDoubleList)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
