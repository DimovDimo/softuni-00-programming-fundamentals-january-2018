using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
            Dictionary<int, int> numberAndCount =
            new Dictionary<int, int>();
            var currentCount = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count >= i + 1)
                {
                    if (i + 1 == numbers.Count)
                    {
                        numberAndCount.Add(numbers[i], currentCount);
                    }
                    else if(numbers[i + 1] != numbers[i])
                    {
                        numberAndCount.Add(numbers[i], currentCount);
                        currentCount = 1;
                    }
                    else
                    {
                        currentCount++;
                    }
                }
            }

            foreach (KeyValuePair<int, int> pair in numberAndCount)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
