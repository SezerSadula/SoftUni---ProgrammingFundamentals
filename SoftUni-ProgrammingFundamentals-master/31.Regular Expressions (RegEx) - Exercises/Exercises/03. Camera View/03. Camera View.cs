using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main()
        {
            var skipTake = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(
                string.Join(
                    ", ",
                    Regex.Matches(
                            Console.ReadLine(),
                            @"\|\<[^|]{" + skipTake[0] + @"}([^|]{0," + skipTake[1] + "})"
                        )
                        .Cast<Match>()
                        .Select(x => x.Groups[1].Value.Trim())
                        .ToList()
                )
            );
        }
    }
}
