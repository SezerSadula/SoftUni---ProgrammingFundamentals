using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main()
        {
            var matches = Regex
                .Matches(Console.ReadLine(), @"<p>(?<text>.+?)<\/p>");

            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                result.Append(string.Concat(Regex
                    .Replace(match.Groups["text"].Value, @"[^a-z0-9]+", " ")
                    .ToCharArray()
                    .Select(chr => (chr >= 'a' && chr <= 'z')
                        ? (char)('a' + (chr - 'a' + 13) % 26)
                        : chr)));
            }

            Console.WriteLine(result.ToString());
        }
    }
}
