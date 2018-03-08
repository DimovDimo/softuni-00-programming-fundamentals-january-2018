using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ', ',', ';', ':', '.', '!', '(', ')', '"',  '\'', '\\', '/', '[', ']')
                .ToList();
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] != "")
                {
                    var upperCaseWord = words[i].ToUpper();
                    var lowerCaseWord = words[i].ToLower();
                    
                    if (words[i] == upperCaseWord
                        && IfInStringItIsNotLetter(words[i]))
                    {
                        upperCase.Add(words[i]);
                    }
                    else if (words[i] == lowerCaseWord
                        && IfInStringItIsNotLetter(words[i]))
                    {
                        lowerCase.Add(words[i]);
                    }
                    else
                    {
                        mixedCase.Add(words[i]);
                    }
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }

        static bool IfInStringItIsNotLetter(string input)
        {
            bool isNotletter = true;
            foreach (var item in input)
            {
                if (!Char.IsLetter(item))
                {
                    isNotletter = false;
                    break;
                }
            }

            return isNotletter;
        }
    }
}
