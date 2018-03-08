using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"..\..\03. Word Count\text.txt")
                .ToLower();
            string[] words = File.ReadAllText(@"..\..\03. Word Count\words.txt")
                .ToLower()
                .Split(' ')
                .Where(x => x != "")
                .ToArray();
            var wordCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word) == false)
                {
                    wordCount.Add(word, 0);
                }

                MatchCollection wordMatches = Regex.Matches(text, $@"\b{word}\b");
                wordCount[word] = wordMatches.Count;
            }

            var output = new List<string>();
            foreach (var word in wordCount
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                output.Add($"{word.Key} - {word.Value}");
            }

            File.WriteAllLines(@"..\..\output.txt", output);
        }
    }
}
