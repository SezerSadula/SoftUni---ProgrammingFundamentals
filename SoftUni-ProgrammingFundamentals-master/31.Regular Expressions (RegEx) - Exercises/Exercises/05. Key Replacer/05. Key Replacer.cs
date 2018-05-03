using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main()
        {
            var m = Regex.Match(
                Console.ReadLine(),
                @"(?<start>[A-Za-z]+).*[\|\<\\](?<end>[A-Za-z]+)");

            var start = m.Groups["start"].Value;
            var end = m.Groups["end"].Value;

            var result = Regex
                .Matches
                (
                    Console.ReadLine(),
                    $@"{start}(?<word>.*?){end}"
                )
                .Cast<Match>()
                .Select(x => x.Groups["word"])
                .Where(x => x.Value != "")
                .ToList();

            if (result.Count > 0)
            {
                Console.WriteLine(string.Concat(result));
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
