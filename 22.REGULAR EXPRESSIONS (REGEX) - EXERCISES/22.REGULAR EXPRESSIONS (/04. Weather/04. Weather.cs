using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Weather
    {
        public string NameOfTheCity { get; set; }
        public double AverageTemperature { get; set; }
        public string TypeOfWeather { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var weathers = new List<Weather>();
            var pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)(\|)";
            var input = Console.ReadLine();
            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    MatchCollection matches = Regex.Matches(input, pattern);
                    foreach (Match match in matches)
                    {
                        var nameOfTheCity = match.Groups[1].Value;
                        var averageTemperature = double.Parse(match.Groups[2].Value);
                        var typeOfWeather = match.Groups[3].Value;
                        if (weathers.Any(x => x.NameOfTheCity == nameOfTheCity) == false)
                        {
                            var currentWeather = new Weather();
                            currentWeather.NameOfTheCity = nameOfTheCity;
                            currentWeather.AverageTemperature = averageTemperature;
                            currentWeather.TypeOfWeather = typeOfWeather;
                            weathers.Add(currentWeather);
                        }
                        else
                        {
                            foreach (var weather in weathers.Where(x => x.NameOfTheCity == nameOfTheCity))
                            {
                                weather.AverageTemperature = averageTemperature;
                                weather.TypeOfWeather = typeOfWeather;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            //“{nameOfTheCity} => {averageTemperature} => {typeOfWeather}”
            foreach (var weather in weathers.OrderBy(x => x.AverageTemperature))
            {
                Console.WriteLine($"{weather.NameOfTheCity} => {weather.AverageTemperature:F2} => {weather.TypeOfWeather}");
            }
        }
    }
}
