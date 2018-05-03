using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main()
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine();

            var matches = Regex
                .Split(text, @"[\.\!\?]")
                .Where(x => Regex.IsMatch(x, $@"\b{keyWord}\b"))
                .Select(x => x.Trim())
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, matches));
        }
    }
}
