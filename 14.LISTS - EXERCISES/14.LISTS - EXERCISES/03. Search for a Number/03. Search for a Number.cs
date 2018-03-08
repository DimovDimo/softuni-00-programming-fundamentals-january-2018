using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToList();
            var elementsForManipulating = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToArray();
            var takedElements = new List<int>();
            for (int i = 0; i < elementsForManipulating[0]; i++)
            {
                takedElements.Add(numbers[i]);
            }

            for (int i = 0; i < takedElements.Count; i++)
            {
                takedElements.Remove(takedElements[0]);
            }

            foreach (var item in takedElements)
            {
                if (item == elementsForManipulating[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }

            Console.WriteLine("NO!");
        }
    }
}
