using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var wordsOutput = new List<string>();
            Random rnd = new Random();
            while (wordsInput.Count > 0)
            {
                var rndNumber = rnd.Next(wordsInput.Count-1);
                var rndWord = wordsInput[rndNumber];
                wordsOutput.Add(rndWord);
                wordsInput.Remove(rndWord);
            }

            foreach (var word in wordsOutput)
            {
                Console.WriteLine(word);
            }
        }
    }
}
