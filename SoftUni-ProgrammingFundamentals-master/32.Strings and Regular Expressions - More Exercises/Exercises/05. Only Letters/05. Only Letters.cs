using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main()
        {
            var message = Console.ReadLine();

            var regex = new Regex(@"(\d+)");

            var sb = new StringBuilder();

            var matches = regex.Matches(message);
            var oldEnd = 0;

            for (var i = 0; i < matches.Count; i++)
            {
                var len = matches[i].Length;
                var start = matches[i].Index;

                if (start + len >= message.Length)
                {
                    break;
                }

                var replChar = message[start + len];

                sb.Append(message.Substring(oldEnd, start - oldEnd));
                sb.Append(replChar);

                oldEnd = start + len;
            }

            sb.Append(message.Substring(oldEnd));

            Console.WriteLine(sb.ToString());

        }
    }
}
