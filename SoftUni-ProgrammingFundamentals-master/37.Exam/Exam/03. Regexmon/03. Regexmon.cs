using System;
using System.Text.RegularExpressions;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var didimon = new Regex(@"(?<didi>[^A-Za-z\-]+)(?<remain>.*)", RegexOptions.Compiled);
            var bojomon = new Regex(@"(?<bojo>[A-Za-z]+\-[A-Za-z]+)(?<remain>.*)", RegexOptions.Compiled);

            var input = Console.ReadLine();

            while (true)
            {
                var match = didimon.Match(input);

                if (match.Success)
                {
                    input = match.Groups["remain"].Value;
                    Console.WriteLine(match.Groups["didi"].Value);
                }
                else
                {
                    break;
                }

                match = bojomon.Match(input);

                if (match.Success)
                {
                    input = match.Groups["remain"].Value;
                    Console.WriteLine(match.Groups["bojo"].Value);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
