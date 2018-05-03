using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    Regex.Matches(
                        Console.ReadLine(),
                        @"(^|(?<=\s))(([A-Za-z0-9]+[_|\.|\-]?[A-Za-z0-9]*)+(?<=[A-Za-z0-9])@(([A-Za-z]+[\-]?\.)+[A-Za-z]+))\s"
                    )
                    .Cast<Match>()
                    .Select(x => x.Value.Trim())
                    .ToList()
                )
            );
        }
    }
}
