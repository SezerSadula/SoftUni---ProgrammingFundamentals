using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main()
        {
            var weathers = new Dictionary<string, Weather>();

            while (true)
            {
                var line = Console.ReadLine();

                if ("end".Equals(line))
                {
                    break;
                }

                var match = Regex.Match(line, 
                    @"(?<city>[A-Z]{2})(?<temperature>\d+\.\d+)(?<weather>[a-zA-Z]+)\|");

                if (!match.Success)
                {
                    continue;
                }

                var weather = new Weather()
                {
                    City = match.Groups["city"].Value,
                    Temperature = double.Parse(match.Groups["temperature"].Value),
                    Type = match.Groups["weather"].Value
                };

                weathers[weather.City] = weather;
            }

            var sorted = weathers.Values
                .OrderBy(x => x.Temperature)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, sorted));
        }

        private class Weather
        {
            public string City { get; set; }
            public double Temperature { get; set; }
            public string Type { get; set; }

            public override string ToString()
            {
                return $"{City} => {Temperature:F2} => {Type}";
            }
        }
    }
}
