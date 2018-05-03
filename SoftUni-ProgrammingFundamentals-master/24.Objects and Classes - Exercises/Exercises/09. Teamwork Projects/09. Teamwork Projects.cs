using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>();

            var teamsToCreate = int.Parse(Console.ReadLine());
            while (teamsToCreate-- > 0)
            {
                var teamData = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                var creatorName = teamData[0];
                var teamName = teamData[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                var team = new Team
                {
                    Name = teamName,
                    CreatorName = creatorName,
                    Members = new List<string>()
                };

                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            var assignment = Console.ReadLine();
            while (!"end of assignment".Equals(assignment))
            {
                var tokens = assignment
                    .Split("->".ToCharArray(), 
                        StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var memberName = tokens[0];
                var teamName = tokens[1];
                if (teams.All(x => x.Name != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.CreatorName == memberName) 
                    || teams.Any(x => x.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    teams[teams.FindIndex(x => x.Name == teamName)]
                        .Members.Add(memberName);
                }

                assignment = Console.ReadLine();
            }

            var sortedTeams = teams
                .Where(team => team.Members.Count > 0)
                .OrderByDescending(team => team.Members.Count)
                .ThenBy(team => team.Name)
                .ToList();

            foreach (var team in sortedTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var teamMember in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {teamMember}");
                }
            }

            var teamsToDisband = teams
                .Where(team => team.Members.Count == 0)
                .OrderBy(team => team.Name)
                .Select(team => team.Name)
                .ToList();

            Console.WriteLine("Teams to disband:");

            if (teamsToDisband.Count > 0)
            {
                Console.WriteLine(string.Join("\n", teamsToDisband));
            }
        }
    }

    class Team
    {
        public string Name { get; set; }

        public List<string> Members { get; set; }

        public string CreatorName { get; set; }
    }
}
