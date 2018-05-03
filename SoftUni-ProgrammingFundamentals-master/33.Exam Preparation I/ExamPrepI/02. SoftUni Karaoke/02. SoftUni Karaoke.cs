using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main()
        {
            var participants = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Distinct()
                .ToDictionary(key => key, value => new SortedSet<string>());

            var songs = new HashSet<string>(
                Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()));

            while (true)
            {
                var performance = Console.ReadLine();

                if ("dawn".Equals(performance))
                {
                    break;
                }

                var tokens = performance
                    .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var performer = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (!songs.Contains(song) || !participants.ContainsKey(performer))
                {
                    continue;
                }

                participants[performer].Add(award);
            }

            if (participants.Any(x => x.Value.Count > 0))
            {
                foreach (var kvp in participants
                    .Where(x => x.Value.Count > 0)
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                    foreach (var award in kvp.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
