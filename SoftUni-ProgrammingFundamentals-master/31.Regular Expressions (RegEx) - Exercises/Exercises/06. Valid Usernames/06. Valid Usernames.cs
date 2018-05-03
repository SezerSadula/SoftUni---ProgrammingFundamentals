using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            var matches = Console.ReadLine()
                    .Split(@"\ /()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .Where(x => Regex.IsMatch(x, @"^[a-zA-Z][a-zA-Z\d_]{2,24}$"))
                    .ToList();

            var bestIndex = 0;
            var bestLength = 0;

            for (var i = 0; i < matches.Count - 1; i++)
            {
                var currentLength = matches[i].Length + matches[i + 1].Length;
                if (currentLength > bestLength)
                {
                    bestIndex = i;
                    bestLength = currentLength;
                }
            }

            Console.WriteLine(matches[bestIndex]);
            Console.WriteLine(matches[bestIndex + 1]);
        }
    }
}