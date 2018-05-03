using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Football_League
{
    class Program
    {
        private const int Scores = 0;
        private const int Goals = 1;

        static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());

            var teamsRegex = new Regex(
                $@"{key}(?<teamA>.*?){key}.*{key}(?<teamB>.*?){key}.*?(?<goalsA>\d+):(?<goalsB>\d+)",
                RegexOptions.Compiled);

            var results = new Dictionary<string, int[]>();

            while (true)
            {
                var result = Console.ReadLine();

                if ("final".Equals(result))
                {
                    break;
                }

                var teams = teamsRegex.Match(result);

                if (!teams.Success)
                {
                    continue;
                }

                var teamA = string.Concat(teams.Groups["teamA"].Value.Trim().ToUpper().Reverse());
                var teamB = string.Concat(teams.Groups["teamB"].Value.Trim().ToUpper().Reverse());
                var goalsA = int.Parse(teams.Groups["goalsA"].Value);
                var goalsB = int.Parse(teams.Groups["goalsB"].Value);

                var scoreA = 0;
                var scoreB = 0;

                if (goalsA == goalsB)
                {
                    scoreA = 1;
                    scoreB = 1;
                }
                else if (goalsA > goalsB)
                {
                    scoreA = 3;
                }
                else
                {
                    scoreB = 3;
                }

                if (!results.ContainsKey(teamA))
                {
                    results[teamA] = new[] { 0, 0 };
                }

                if (!results.ContainsKey(teamB))
                {
                    results[teamB] = new[] { 0, 0 };
                }

                results[teamA][Scores] += scoreA;
                results[teamA][Goals] += goalsA;
                results[teamB][Scores] += scoreB;
                results[teamB][Goals] += goalsB;
            }

            Console.WriteLine("League standings:");

            var place = 1;
            foreach (var kvpTeam in results
                .OrderByDescending(x => x.Value[Scores])
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place++}. {kvpTeam.Key} {kvpTeam.Value[Scores]}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var kvpTeam in results
                .OrderByDescending(x => x.Value[Goals])
                .ThenBy(x => x.Key)
                .Take(3))
            {
                Console.WriteLine($"- {kvpTeam.Key} -> {kvpTeam.Value[Goals]}");
            }
        }
    }
}
