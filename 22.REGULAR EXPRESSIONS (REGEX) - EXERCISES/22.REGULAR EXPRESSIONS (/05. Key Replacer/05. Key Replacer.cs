using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyString = Console.ReadLine();
            var keyPattern = @"([A-Za-z]+?)(<|\||\\)(.*?)(<|\||\\)([A-Za-z]+)";
            MatchCollection matchesKey = Regex.Matches(keyString, keyPattern);
            var startKey = "";
            var endKey = "";
            foreach (Match match in matchesKey)
            {
                startKey = match.Groups[1].Value;
                endKey = match.Groups[5].Value;
            }

            var textString = Console.ReadLine();
            var textPattern = @"(" + startKey + @")([A-Za-z]*?)(" + endKey + @")"; //(A)([A-Za-z]*?)(B)
            MatchCollection matchesText = Regex.Matches(textString, textPattern);
            var result = new List<string>();
            foreach (Match match in matchesText)
            {
                result.Add(match.Groups[2].Value);
            }

            if (string.Join("", result) == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(string.Join("", result));
            }
        }
    }
}
