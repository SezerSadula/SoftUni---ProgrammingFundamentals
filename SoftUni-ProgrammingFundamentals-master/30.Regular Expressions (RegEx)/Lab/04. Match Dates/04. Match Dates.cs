using System;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main()
        {
            var matches = Regex.Matches(
                        Console.ReadLine(),
                        @"\b(?<day>\d{2})([.\/-])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b");

            foreach (Match date in matches)
            {
                Console.WriteLine($@"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
