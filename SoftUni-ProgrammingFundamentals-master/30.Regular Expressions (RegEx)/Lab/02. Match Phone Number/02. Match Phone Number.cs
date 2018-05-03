using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(", ",
                Regex.Matches(
                    Console.ReadLine(),
                    @"(?<=\A|\s)(\+359([ -])2\2\d{3}\2\d{4})\b")
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList()));
        }
    }
}
