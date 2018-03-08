using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = new SortedDictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "report")
                {
                    foreach (var countryPair in country.OrderByDescending(c => c.Value.Values.Sum()))
                    {
                        Console.WriteLine($"{countryPair.Key} (total population: {countryPair.Value.Values.Sum()})");
                        foreach (var cityPair in countryPair.Value.OrderByDescending(cp => cp.Value))
                        {
                            Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                        }
                    }

                    return;
                }

                var separated = input
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                var city = separated[0];
                var countryCurrent = separated[1];
                var population = separated[2];
                if (country.ContainsKey(countryCurrent) == false)
                {
                    var emptyDic = new Dictionary<string, long>();
                    country.Add(countryCurrent, emptyDic);
                }

                if (country[countryCurrent].ContainsKey(city) == false)
                {
                    country[countryCurrent].Add(city, 0);
                }

                country[countryCurrent][city] += int.Parse(population);
            }
        }
    }
}
