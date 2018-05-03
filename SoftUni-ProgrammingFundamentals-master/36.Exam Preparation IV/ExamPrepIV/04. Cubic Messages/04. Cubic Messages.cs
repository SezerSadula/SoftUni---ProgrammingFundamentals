using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(
                @"(?:^)\d+(?<text>[A-Za-z]*)(?=[^A-Za-z]*$)",
                RegexOptions.Compiled);

            var regNums = new Regex(
                @"\d",
                RegexOptions.Compiled);

            while (true)
            {
                var input = Console.ReadLine();

                if ("Over!".Equals(input))
                {
                    break;
                }

                var len = int.Parse(Console.ReadLine());
                var match = regex.Match(input);

                if (!match.Success
                    || match.Groups["text"].Value.Length != len)
                {
                    continue;
                }

                var text = match.Groups["text"].Value;
                var textLen = text.Length;

                var sb = new StringBuilder(
                    $"{text} == ");

                var nums = regNums.Matches(input);

                foreach (Match num in nums)
                {
                    var index = int.Parse(num.Value);

                    if (index >= 0 && index < textLen)
                    {
                        sb.Append(text[index]);
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
