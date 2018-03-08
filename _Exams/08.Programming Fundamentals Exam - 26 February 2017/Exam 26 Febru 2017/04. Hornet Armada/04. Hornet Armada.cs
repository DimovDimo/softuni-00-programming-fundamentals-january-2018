using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Soldier
    {
        public string Type { get; set; }
        public long Count { get; set; }
    }

    class Legion
    {
        public string Name { get; set; }
        public long Activity { get; set; }
        public List<Soldier> Soldiers { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var legions = new List<Legion>();
            var n = int.Parse(Console.ReadLine());
            var pattern = @"(.+) = (.+) -> (.+):(.+)";
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                MatchCollection matches = Regex.Matches(line, pattern);
                var activity = long.Parse(matches[0].Groups[1].Value);
                var legionName = matches[0].Groups[2].Value;
                var solderType = matches[0].Groups[3].Value;
                var solderCount = long.Parse(matches[0].Groups[4].Value);
                if (legions.Any(x => x.Name == legionName) == false)
                {
                    var currentLegion = new Legion();
                    currentLegion.Name = legionName;
                    currentLegion.Activity = activity;
                    var currentEmptySolders = new List<Soldier>();
                    var currentEmptySolder = new Soldier();
                    currentEmptySolder.Type = solderType;
                    currentEmptySolder.Count = solderCount;
                    currentEmptySolders.Add(currentEmptySolder);
                    currentLegion.Soldiers = currentEmptySolders;
                    legions.Add(currentLegion);
                }
                else
                {
                    var legionFirst = legions.First(x => x.Name == legionName);
                    if (legionFirst.Activity < activity)
                    {
                        legionFirst.Activity = activity;
                    }

                    if (legionFirst.Soldiers.Any(x => x.Type == solderType) == false)
                    {
                        var currentEmptySolder = new Soldier();
                        currentEmptySolder.Type = solderType;
                        currentEmptySolder.Count = solderCount;
                        legionFirst.Soldiers.Add(currentEmptySolder);
                    }
                    else
                    {
                        var currentSolderTypeFirst = legionFirst.Soldiers.First(x => x.Type == solderType);
                        currentSolderTypeFirst.Count += solderCount;
                    }
                }
            }

            var outputCommant = Console.ReadLine();
            if (Regex.IsMatch(outputCommant, @"(\d+)\\(.+)"))
            {
                MatchCollection matchesCommand = Regex.Matches(outputCommant, @"(\d+)\\(.+)");
                var activityCommand = long.Parse(matchesCommand[0].Groups[1].Value);
                var soldierTypeCommand = matchesCommand[0].Groups[2].Value;
                var countSoldersByType = new Dictionary<string, long>();
                foreach (var legion in legions.Where(x => x.Activity < activityCommand))
                {// 0 solders
                    if (legion.Soldiers.Any(x => x.Type == soldierTypeCommand))
                    {
                        countSoldersByType.Add(legion.Name, legion.Soldiers.First(x => x.Type == soldierTypeCommand).Count);
                    }
                    //else
                    //{
                    //    countSoldersByType.Add(legion.Name, 0L);
                    //}
                }

                foreach (var pair in countSoldersByType.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
            else
            {
                var legionWithActivity = new Dictionary<string, long>();
                foreach (var legion in legions.Where(x => x.Soldiers.Any(z => z.Type == outputCommant)))
                {
                    legionWithActivity.Add(legion.Name, legion.Activity);
                }

                foreach (var pair in legionWithActivity.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{pair.Value} : {pair.Key}");
                }
            }
        }
    }
}
