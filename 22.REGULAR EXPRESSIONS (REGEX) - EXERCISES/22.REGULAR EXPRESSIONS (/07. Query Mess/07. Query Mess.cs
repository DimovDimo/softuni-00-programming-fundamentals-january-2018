using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            //var weathers = new List<Weather>();
            var pattern = @"([^=&?\n]+)=([^=&?\n]+)";
            var input = Console.ReadLine();
            while (input != "END")
            {
                var queryMess = new Dictionary<string, List<string>>();
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    var field = match.Groups[1].Value;
                    field = Regex.Replace(field, @"(%20|\+)+", " ").Trim();
                    if (queryMess.ContainsKey(field) == false)
                    {
                        var emptyList = new List<string>();
                        queryMess.Add(field, emptyList);
                    }

                    //StringBuilder value = new StringBuilder();
                    //value.Append(match.Groups[2].Value);
                    //value.Replace("+", " ");
                    //value.Replace("%20", " ");
                    //string patternSPlus = @"(%20|\+)+";
                    //string replacementSpace = " ";
                    //Regex rgx = new Regex(patternSPlus);
                    //string resultText = rgx.Replace(value.ToString(), replacementSpace);
                    var value = match.Groups[2].Value;
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();
                    queryMess[field].Add(value);
                }

                foreach (var mess in queryMess)
                {
                    //var trimedValues = mess.Value
                    //    .Select(x => x.ToString().Trim())
                    //    .ToList();
                    Console.Write($"{mess.Key}=[{string.Join(", ", mess.Value)}]");
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
