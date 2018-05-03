using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main()
        {
            var matches = Regex.Matches(
                Console.ReadLine(),
                @"(?<word>.+?)(?<count>\d+)");

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Insert(sb.Length,
                    match.Groups["word"].Value.ToUpper(),
                    int.Parse(match.Groups["count"].Value));
            }

            var uniqueSymbolsCount = sb.ToString().ToCharArray().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(sb.ToString());
        }
    }
}
