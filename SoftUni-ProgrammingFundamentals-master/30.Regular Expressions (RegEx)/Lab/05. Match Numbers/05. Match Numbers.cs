using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine
            (
                string.Join
                (
                    " ",
                    Regex.Matches
                    (
                        Console.ReadLine(),
                        @"(^|(?<=\s))(-?\d+\.?\d*)($|(?=\s))"
                    )
                    .Cast<Match>()
                    .Select(x => x.Value)
                    .ToList()
                )
            );
        }
    }
}
