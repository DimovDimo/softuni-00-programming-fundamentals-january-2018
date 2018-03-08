using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var patternBojomon = @"([A-Za-z]+-[A-Za-z]+)(.*)";
            var patternDidimon = @"([^-A-Za-z]+)(.*)";// (.+)
            while (input.Length > 0)
            {
                if (Regex.IsMatch(input, patternDidimon))
                {
                    MatchCollection matchesDidimon = Regex.Matches(input, patternDidimon);
                    Console.WriteLine(matchesDidimon[0].Groups[1].Value);
                    input = matchesDidimon[0].Groups[2].Value;
                }
                else
                {
                    break;
                }

                if (Regex.IsMatch(input, patternBojomon))
                {
                    MatchCollection matchesBojomon = Regex.Matches(input, patternBojomon);
                    Console.WriteLine(matchesBojomon[0].Groups[1].Value);
                    input = matchesBojomon[0].Groups[2].Value;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
