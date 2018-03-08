using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regexed = input
                .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            foreach (var word in regexed)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", 
                palindromes
                .Distinct()
                .OrderBy(x => x)));
        }

        static bool IsPalindrome(string word)
        {
            var reversed = new string(word
                .Reverse()
                .ToArray());
            if (word == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
