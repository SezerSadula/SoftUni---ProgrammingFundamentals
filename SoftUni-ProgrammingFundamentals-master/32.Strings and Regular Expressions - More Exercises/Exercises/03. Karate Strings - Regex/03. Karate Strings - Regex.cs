using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"(\w*)(\>)(\d)(\w*)");

            var matches = regex.Matches(Console.ReadLine());

            var sb = new StringBuilder();
            var prev = 0;
            for (var i = 0; i < matches.Count; i++)
            {
                sb.Append(matches[i].Groups[1]);
                sb.Append(matches[i].Groups[2]);

                var kick = prev;
                prev = 0;
                if (matches[i].Groups[3].Length > 0)
                {
                    kick += int.Parse(matches[i].Groups[3].ToString()) - 1;

                    if (kick < 0)
                    {
                        kick = 0;
                        sb.Append(matches[i].Groups[3]);
                    }
                }

                if (kick > matches[i].Groups[4].Length)
                {
                    prev = kick - matches[i].Groups[4].Length;
                    kick = matches[i].Groups[4].Length;
                }

                sb.Append(matches[i].Groups[4].ToString().Substring(kick));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
