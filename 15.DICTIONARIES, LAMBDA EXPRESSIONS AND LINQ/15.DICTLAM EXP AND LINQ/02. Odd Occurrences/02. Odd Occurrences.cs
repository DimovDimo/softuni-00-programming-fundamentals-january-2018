using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStringsList = Console.ReadLine()
                .Split(' ')
                .ToList();
            for (int i = 0; i < inputStringsList.Count; i++)
            {
                inputStringsList[i] = inputStringsList[i].ToLower();
            }

            var dictionary = new Dictionary<string, int>();
            foreach (var word in inputStringsList)
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

            var oddCountOfWords = new List<string>();
            foreach (var pair in dictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    oddCountOfWords.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddCountOfWords));
        }
    }
}
