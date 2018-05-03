using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"^(?<name>[A-Za-z]{5,})@(?<server>[a-z]{3,}[.](com|bg|org))$");

            var servers = new Dictionary<string, List<string>>();

            var count = int.Parse(Console.ReadLine());

            while (count-- > 0)
            {
                var match = regex.Match(Console.ReadLine());

                if (!match.Success)
                {
                    continue;
                }

                var server = match.Groups["server"].Value;

                if (!servers.ContainsKey(server))
                {
                    servers.Add(server, new List<string>());
                }

                var name = match.Groups["name"].Value;

                if (!servers[server].Contains(name))
                {
                    servers[server].Add(name);
                }
            }

            foreach (var server in servers.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{server.Key}:");

                foreach (var mail in server.Value)
                {
                    Console.WriteLine($"### {mail}");
                }
            }
        }
    }
}
