using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Team
    {
        public string Name { get; set; }
        public long ScoredGoals { get; set; }
        public long Points { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var league = new List<Team>();
            var keyRegex = Console.ReadLine();
            var escaped = Regex.Escape(keyRegex);
            //var escaped = Regex.Escape(@"(.*)(??)(.+)(\2)(.*)(\2)(.+)(\2)(.*?)(\d+):(\d+)(.*)");
            var pattern = $@"(.*)({escaped})(.+)(\2)(.*)(\2)(.+)(\2)(.*?)(\d+):(\d+)(.*)";
            var line = Console.ReadLine();
            while (line != "final")
            {//try
                MatchCollection matches = null;
                //try
                //{
                    matches = Regex.Matches(line, pattern);
                    var test = Reverse(matches[0].Groups[3].Value.ToUpper().ToString());
                //}
                //catch (Exception)
                //{
                //    var patternChar = new List<string>();
                //    for (int i = 0; i < keyRegex.Length; i++)
                //    {
                //        var specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,".ToCharArray();
                //        if (specialChar.Any(x => x == keyRegex[i]))
                //        {
                //            patternChar.Add("\\" + keyRegex[i]);
                //        }
                //        else
                //        {
                //            patternChar.Add(keyRegex[i].ToString());
                //        }
                //    }
                //
                //    var mostEscaped = string.Join("", patternChar);
                //    pattern = $@"(.*)({mostEscaped})(.+)(\2)(.*)(\2)(.+)(\2)(.*?)(\d+):(\d+)(.*)";
                //    matches = Regex.Matches(line, pattern);
                //    var test = Reverse(matches[0].Groups[3].Value.ToUpper().ToString());
                //}
                //MatchCollection matches = Regex.Matches(line, pattern);////////////
                var team1Name = Reverse(matches[0].Groups[3].Value.ToUpper().ToString());
                //team1Name.Reverse();
                var team2Name = Reverse(matches[0].Groups[7].Value.ToUpper().ToString());
                //team2Name.Reverse();
                var team1Goals = int.Parse(matches[0].Groups[10].Value);
                var team2Goals = int.Parse(matches[0].Groups[11].Value);
                if (league.Any(x => x.Name == team1Name) == false)
                {
                    var currentTeam = new Team();
                    currentTeam.Name = team1Name;
                    currentTeam.Points = 0;
                    currentTeam.ScoredGoals = 0;
                    league.Add(currentTeam);
                }

                if (league.Any(x => x.Name == team2Name) == false)
                {
                    var currentTeam = new Team();
                    currentTeam.Name = team2Name;
                    currentTeam.Points = 0;
                    currentTeam.ScoredGoals = 0;
                    league.Add(currentTeam);
                }

                var firstTeam1 = league.First(x => x.Name == team1Name);
                firstTeam1.ScoredGoals += team1Goals;
                var firstTeam2 = league.First(x => x.Name == team2Name);
                firstTeam2.ScoredGoals += team2Goals;

                var pointsTeam1 = 0;
                var pointsTeam2 = 0;
                if (team1Goals == team2Goals)
                {
                    pointsTeam1 = 1;
                    pointsTeam2 = 1;
                }
                else if (team1Goals > team2Goals)
                {
                    pointsTeam1 = 3;
                    pointsTeam2 = 0;
                }
                else if (team1Goals < team2Goals)
                {
                    pointsTeam1 = 0;
                    pointsTeam2 = 3;
                }

                var firstTeam1Points = league.First(x => x.Name == team1Name);
                firstTeam1Points.Points += pointsTeam1;
                var firstTeam2Points = league.First(x => x.Name == team2Name);
                firstTeam2Points.Points += pointsTeam2;

                line = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            var leagueStandings = league.OrderByDescending(x => x.Points).ThenBy(x => x.Name).ToList();
            for (int i = 0; i < leagueStandings.Count; i++)
            {
                Console.WriteLine($@"{i + 1}. {leagueStandings[i].Name} {leagueStandings[i].Points}");
            }

            Console.WriteLine("Top 3 scored goals:");
            var top3ScoredGoals = league.OrderByDescending(x => x.ScoredGoals).ThenBy(x => x.Name).Take(3).ToList();//thenby
            for (int i = 0; i < top3ScoredGoals.Count; i++)
            {
                Console.WriteLine($@"- {top3ScoredGoals[i].Name} -> {top3ScoredGoals[i].ScoredGoals}");
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
