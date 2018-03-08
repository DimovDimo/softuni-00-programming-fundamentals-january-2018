using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm
{
    class Privite
    {
        public string RecipientCode { get; set; }
        public string Massage { get; set; }
    }

    class Broadcast
    {
        public string Frequency { get; set; }
        public string Massage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var privites = new List<Privite>();
            var broadcastes = new List<Broadcast>();
            var line = Console.ReadLine();
            while (line != "Hornet is Green")
            {
                var splited = line
                    .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (splited.Count >= 2)
                {
                    var firstQuery = splited[0];
                    var secondQuery = splited[1];
                    var patternDigitsPrivite = @"(\d)";
                    var patternDigitsLettersPrivite = @"([\dA-Za-z])";
                    var patternDigitsBrodcast = @"([^\d])";
                    var patternDigitsLettersBrodcast = @"([\dA-Za-z])";
                    MatchCollection matchesPriviteFirst = Regex.Matches(firstQuery, patternDigitsPrivite);
                    MatchCollection matchesPriviteSecond = Regex.Matches(secondQuery, patternDigitsLettersPrivite);
                    MatchCollection matchesBrodcastFirst = Regex.Matches(firstQuery, patternDigitsBrodcast);
                    MatchCollection matchesBrodcastSecond = Regex.Matches(secondQuery, patternDigitsLettersBrodcast);
                    if (matchesPriviteFirst.Count == firstQuery.Length &&
                        matchesPriviteSecond.Count == secondQuery.Length)//privite
                    {
                        var currentPrivite = new Privite();
                        currentPrivite.RecipientCode = Reverse(firstQuery);
                        currentPrivite.Massage = secondQuery;
                        privites.Add(currentPrivite);
                    }
                    else if (matchesBrodcastFirst.Count == firstQuery.Length &&
                            matchesBrodcastSecond.Count == secondQuery.Length)//brodcast
                    {
                        var currentBrodcast = new Broadcast();
                        currentBrodcast.Massage = firstQuery;
                        var secondQueryList = new List<string>();
                        for (int i = 0; i < secondQuery.Length; i++)
                        {
                            if (secondQuery[i] >= 97 && secondQuery[i] <= 122)
                            {
                                secondQueryList.Add(secondQuery[i].ToString().ToUpper());
                            }
                            else if (secondQuery[i] >= 65 && secondQuery[i] <= 90)
                            {
                                secondQueryList.Add(secondQuery[i].ToString().ToLower());
                            }
                            else
                            {
                                secondQueryList.Add(secondQuery[i].ToString());
                            }
                        }

                        currentBrodcast.Frequency = string.Join("", secondQueryList);
                        broadcastes.Add(currentBrodcast);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastes.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcastes)
                {
                    Console.WriteLine($"{broadcast.Frequency} -> {broadcast.Massage}");
                }
            }

            Console.WriteLine("Messages:");
            if (broadcastes.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var privit in privites)
                {
                    Console.WriteLine($"{privit.RecipientCode} -> {privit.Massage}");
                }
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
