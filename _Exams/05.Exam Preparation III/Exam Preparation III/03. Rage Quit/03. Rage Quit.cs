using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([^0-9]+)(\d+)";//double
            var line = Console.ReadLine();
            MatchCollection matches = Regex.Matches(line, pattern);
            var output = new StringBuilder();
            foreach (Match match in matches)
            {
                var text = match.Groups[1].Value.ToUpper();
                var number = int.Parse(match.Groups[2].Value);//big
                output.Append(String.Join("", Enumerable.Range(0, number).Select(i => text)));
            }

            Console.WriteLine($"Unique symbols used: {output.ToString().ToCharArray().Distinct().Count()}");
            Console.WriteLine(output);
        }
    }
}
