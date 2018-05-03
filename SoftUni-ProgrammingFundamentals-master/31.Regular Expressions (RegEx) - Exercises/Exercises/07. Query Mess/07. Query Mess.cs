using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if ("END".Equals(input))
                {
                    break;
                }

                var queriesStr = input
                    .Split("&?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => Regex.IsMatch(x, @".+=.+"));

                var queries = new Dictionary<string, List<string>>();

                foreach (var queryStr in queriesStr)
                {
                    var query = queryStr
                        .Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => Regex.Replace(x, @"(%20|\+)+", " "))
                        .Select(x => x.Trim())
                        .ToList();

                    var key = query[0];
                    var value = query[1];

                    if (!queries.ContainsKey(key))
                    {
                        queries[key] = new List<string>();
                    }

                    queries[key].Add(value);
                }

                foreach (var query in queries)
                {
                    Console.Write($"{query.Key}=[{string.Join(", ", query.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}
