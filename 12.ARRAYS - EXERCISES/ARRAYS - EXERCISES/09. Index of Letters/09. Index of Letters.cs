using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            foreach (var letter in word)
            {
                int numInAlphabet = letter - 97;
                Console.WriteLine($"{letter} -> {numInAlphabet}");
            }
        }
    }
}
