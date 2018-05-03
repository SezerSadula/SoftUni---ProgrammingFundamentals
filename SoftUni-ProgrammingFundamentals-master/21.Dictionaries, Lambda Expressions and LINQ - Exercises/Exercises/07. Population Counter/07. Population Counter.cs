using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();

            var line = Console.ReadLine();

            while (!line.Equals("report"))
            {
                var data = line.Split('|').ToArray();
                var country = data[1];
                var city = data[0];
                var population = long.Parse(data[2]);

                if (!countries.ContainsKey(country))
                {
                    countries[country] = new Dictionary<string, long>();
                }

                countries[country][city] = population;

                line = Console.ReadLine();
            }

            countries = countries
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var country in countries)
            {
                var countryPopulation = country
                    .Value
                    .Values
                    .Sum();

                Console.WriteLine($"{country.Key} (total population: {countryPopulation})");

                var cities = country
                    .Value
                    .OrderByDescending(x => x.Value)
                    .ToList();

                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
