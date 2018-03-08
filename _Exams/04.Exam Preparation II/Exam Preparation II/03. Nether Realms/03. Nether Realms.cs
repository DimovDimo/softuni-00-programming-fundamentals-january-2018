using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demos = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x);
            var patternHealt = @"([^0-9+\-*\/.])";
            var patternDamaganeNumbers = @"(?<=\+|)([0-9\-.]+)";
            var patternDamaganeOperators = @"([*\/])";
            foreach (var demo in demos)
            {

                long healt = 0;
                MatchCollection matchesHealt = Regex.Matches(demo, patternHealt);
                foreach (Match letter in matchesHealt)
                {
                    healt += letter.Groups[1].Value.ToCharArray().Sum(x => (long)x);
                }

                var dagane = 0.0M;
                MatchCollection matchesDamaganeNumbers = Regex.Matches(demo, patternDamaganeNumbers);
                foreach (Match number in matchesDamaganeNumbers)
                {
                    var numberStr = number.Groups[1].Value;
                    if (numberStr[0] == '-')
                    {
                        var patternDamaganeNumbersMinus = @"(-[0-9.]+)";
                        MatchCollection matchesDamaganeNumbersMinus = Regex.Matches(demo, patternDamaganeNumbersMinus);
                        foreach (var item in matchesDamaganeNumbersMinus)
                        {
                            var itemStr = item.ToString();
                            dagane += decimal.Parse(itemStr, CultureInfo.InvariantCulture);
                        }
                    }
                    else
                    {
                        dagane += decimal.Parse(numberStr, CultureInfo.InvariantCulture);
                    }
                }//error

                MatchCollection matchesDamaganeOperators = Regex.Matches(demo, patternDamaganeOperators);
                foreach (Match operatorNum in matchesDamaganeOperators)
                {
                    var operatorNumStr = operatorNum.Groups[1].Value;
                    if (operatorNumStr == "*")
                    {
                        dagane *= 2;
                    }
                    else if (operatorNumStr == "/")
                    {
                        dagane /= 2;
                    }
                }

                Console.WriteLine($"{demo} - {healt:F0} health, {dagane:F2} damage");
            }
        }
    }
}
