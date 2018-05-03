using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregatedLogs = 
                new SortedDictionary<string, SortedDictionary<string, int>>();

            var lines = int.Parse(Console.ReadLine());

            for (int line = 0; line < lines; line++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                var ipAddress = tokens[0]; 
                var user = tokens[1];
                var duration = int.Parse(tokens[2]);

                if (!aggregatedLogs.ContainsKey(user))
                {
                    aggregatedLogs[user] = new SortedDictionary<string, int>();
                }

                if (!aggregatedLogs[user].ContainsKey(ipAddress))
                {
                    aggregatedLogs[user].Add(ipAddress, 0);
                }

                aggregatedLogs[user][ipAddress] += duration;
            }

            foreach (var userLog in aggregatedLogs)
            {
                var user = userLog.Key;
                var duration = userLog.Value.Values.Sum();
                var addresses = string.Join(", ", userLog.Value.Keys);

                Console.WriteLine($"{user}: {duration} [{addresses}]");
            }
        }
    }
}
