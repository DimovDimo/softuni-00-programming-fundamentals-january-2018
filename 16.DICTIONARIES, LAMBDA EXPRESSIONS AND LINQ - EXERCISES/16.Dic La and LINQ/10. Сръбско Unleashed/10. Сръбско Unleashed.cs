using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    foreach (var currentVenue in venues)
                    {
                        Console.WriteLine(currentVenue.Key);
                        foreach (var currentSinger in currentVenue.Value.OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine($"#  {currentSinger.Key} -> {currentSinger.Value}");
                        }
                    }

                    return;
                }

                if (IsSkiped(input))
                {

                    var separatedBySpace = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    var ticketsCount = int.Parse(separatedBySpace[separatedBySpace.Count - 1]);
                    separatedBySpace.RemoveAt(separatedBySpace.Count - 1);
                    var ticketsPrice = int.Parse(separatedBySpace[separatedBySpace.Count - 1]);
                    separatedBySpace.RemoveAt(separatedBySpace.Count - 1);
                    var price = ticketsCount * ticketsPrice;

                    var singerNames = new List<string>();
                    foreach (var item in separatedBySpace)
                    {
                        if (item[0] != '@')
                        {
                            singerNames.Add(item);
                        }
                        else
                        {
                            break;
                        }
                    }

                    var singer = string.Join(" ", singerNames);
                    var venueNames = new List<string>();
                    for (int i = separatedBySpace.Count - 1; i >= 0; i--)
                    {
                        if (separatedBySpace[i][0] == '@')
                        {
                            var venueName = string.Join("", 
                                separatedBySpace[i]
                                .ToString()
                                .Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToList());
                            venueNames.Add(venueName);
                            break;
                        }
                        else
                        {
                            venueNames.Add(separatedBySpace[i]);
                        }
                    }
                    
                    var venue = string.Join(" ", venueNames.OrderByDescending(x => x));
                    if (venues.ContainsKey(venue) == false)
                    {
                        var emptyDic = new Dictionary<string, long>();
                        venues.Add(venue, emptyDic);
                    }
                    
                    if (venues[venue].ContainsKey(singer) == false)
                    {
                        venues[venue].Add(singer, 0);
                    }
                    
                    venues[venue][singer] += price;
                }
            }
        }

       static bool IsSkiped(string input)
        {
            bool isSkiped = true;
            var isFirstLetterIsSpiralA = false;
            var separatedBySpace = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            if (separatedBySpace.Count == 1)
            {
                return false;
            }

            foreach (var item in separatedBySpace)
            {
                if (item[0] == '@')
                {
                    isFirstLetterIsSpiralA = true;
                    break;
                }
            }

            if (isFirstLetterIsSpiralA == false)
            {
                return false;
            }

            int empty = 0;
            if (int.TryParse(separatedBySpace[separatedBySpace.Count - 1], out empty)
                && int.TryParse(separatedBySpace[separatedBySpace.Count - 2], out empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
