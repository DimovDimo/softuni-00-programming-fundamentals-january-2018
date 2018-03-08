using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternSurface = @"([^A-Za-z0-9]+)";
            var patternMantle = @"([0-9_]+)";
            var patternCore = @"([^A-Za-z0-9]+)([0-9_]+([A-Za-z]+))([0-9_]+)([^A-Za-z0-9]+)";
            var line1Surface = Console.ReadLine();
            var line2Mantle = Console.ReadLine();
            var line3Core = Console.ReadLine();
            var line4Mantle = Console.ReadLine();
            var line5Surface = Console.ReadLine();
            MatchCollection matchesLine1Surface = Regex.Matches(line1Surface, patternSurface);
            MatchCollection matchesLine2Mantle = Regex.Matches(line2Mantle, patternMantle);
            MatchCollection matchesLine3Core = Regex.Matches(line3Core, patternCore);
            MatchCollection matchesLine4Mantle = Regex.Matches(line4Mantle, patternMantle);
            MatchCollection matchesLine5Surface = Regex.Matches(line5Surface, patternSurface);
            var match1Line1Surface = "";
            var match2Line2Mantle = "";
            var match3Line3Core = "";
            var textCore = "";
            var match4Line4Mantle = "";
            var match5Line5Surface = "";
            foreach (Match item in matchesLine1Surface)
            {
                match1Line1Surface = item.Groups[1].Value;
            }

            foreach (Match item in matchesLine2Mantle)
            {
                match2Line2Mantle = item.Groups[1].Value;
            }

            foreach (Match item in matchesLine3Core)
            {
                match3Line3Core = item.Groups[0].Value;
                textCore = item.Groups[3].Value;
            }

            foreach (Match item in matchesLine4Mantle)
            {
                match4Line4Mantle = item.Groups[1].Value;
            }

            foreach (Match item in matchesLine5Surface)
            {
                match5Line5Surface = item.Groups[1].Value;
            }

            if (line1Surface == match1Line1Surface &&
                line2Mantle == match2Line2Mantle &&
                line3Core == match3Line3Core &&
                line4Mantle == match4Line4Mantle &&
                line5Surface == match5Line5Surface)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(textCore.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
