using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var singers = new Dictionary<string, List<string>>();
            var listSingers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var listSongs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var line = Console.ReadLine();
            while (line != "dawn")
            {
                var splited = line
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var participant = splited[0];
                var song = splited[1];
                var award = splited[2];
                if (listSingers.Any(x => x == participant) &&
                    listSongs.Any(x => x == song))
                {
                    if (singers.ContainsKey(participant) == false)
                    {
                        var emtyList = new List<string>();
                        singers.Add(participant, emtyList);
                    }

                    if (singers[participant].Any(x => x == award) == false)
                    {
                        singers[participant].Add(award);
                    }
                }

                line = Console.ReadLine();
            }

            if (singers.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var singer in singers
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    foreach (var award in singer.Value
                        .OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
