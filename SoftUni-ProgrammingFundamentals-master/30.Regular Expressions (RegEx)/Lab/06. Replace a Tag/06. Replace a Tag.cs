using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();

            while (true)
            {
                var line = Console.ReadLine();

                if ("end".Equals(line))
                {
                    break;
                }

                sb.AppendLine(line);
            }

            Console.WriteLine(
                Regex.Replace(
                    sb.ToString(),
                    @"(.*)(\<a)\s*(href.*)(>)(.*)(<\/a>)(.*)",
                    @"$1[URL $3]$5[/URL]$7",
                    RegexOptions.Multiline));
        }
    }
}
