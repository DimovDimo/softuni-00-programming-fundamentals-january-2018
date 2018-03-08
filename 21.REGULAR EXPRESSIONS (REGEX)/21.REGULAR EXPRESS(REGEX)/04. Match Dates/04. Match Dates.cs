using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";
            string datesInput = Console.ReadLine();
            MatchCollection dates = Regex.Matches(datesInput, regex);
            //var matchedDates = dates
            //    .Cast<Match>()
            //    .Select(a => a.Value.Trim())
            //    .ToArray();
            foreach(Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
