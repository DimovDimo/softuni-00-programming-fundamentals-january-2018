using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var skipNums = numbers[0];
            var getNums = numbers[1];
            //var pattern = @"\|<([\w]{" + skipNums + @"})([\w]{0," + skipNums + @"})";
            var pattern = @"\|<([\w]{" + skipNums + @"})([\w]{0," + getNums + @"})";
            var input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            var result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
