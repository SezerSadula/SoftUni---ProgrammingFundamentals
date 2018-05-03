using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ",
                Regex.Matches(
                        Console.ReadLine(),
                        @"\b[0x]*[A-F0-9]+\b")
                    .Cast<Match>()
                    .Select(x => x.Value.Trim())
                    .ToList()));
        }
    }
}
