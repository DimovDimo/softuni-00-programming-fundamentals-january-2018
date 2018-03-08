using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var decripted = new List<string>();//time
            for (int i = 0; i < n; i++)
            {
                var messageEncripted = Console.ReadLine();
                MatchCollection matches = Regex.Matches(messageEncripted, @"([starSTAR])");
                var key = matches.Count;
                var messageDecripted = new StringBuilder();
                for (int j = 0; j < messageEncripted.Length; j++)
                {
                    messageDecripted.Append((char)(messageEncripted[j] - key));
                }

                decripted.Add(messageDecripted.ToString());
            }

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();
            foreach (var element in decripted)
            {
                var pattern = @"@([A-Za-z]+)([^@\-!:>]+|):(\d+)([^@\-!:>]+|)!([AD])!([^@\-!:>]+|)->(\d+)([^@\-!:>]+|)";
                if (Regex.IsMatch(element, pattern))
                {
                    MatchCollection planetMatch = Regex.Matches(element, pattern);
                    var planet = planetMatch[0].Groups[1].Value;
                    if (Regex.IsMatch(element, @"!([A])!"))
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
