using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?:0x)?[\d+A-F]+\b";
            string numbersAsString = Console.ReadLine();
            MatchCollection hexNums = Regex.Matches(numbersAsString, regex);
            var matchedHexNums = hexNums
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(" ",
                matchedHexNums));
        }
    }
}
