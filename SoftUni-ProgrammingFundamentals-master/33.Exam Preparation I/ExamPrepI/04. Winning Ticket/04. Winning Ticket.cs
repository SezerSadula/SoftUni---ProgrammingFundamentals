using System;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    internal class Program
    {
        private static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var noMatch = true;

                foreach (var winChar in "@#$^".ToCharArray())
                {
                    var winReg = new Regex($@"[\{winChar}]{{6,}}");

                    var part1 = winReg.Match(ticket.Substring(0, 10));
                    var part2 = winReg.Match(ticket.Substring(10, 10));

                    if (!part1.Success || !part2.Success)
                    {
                        continue;
                    }

                    var matchLength = Math.Min(part1.Length, part2.Length);

                    Console.WriteLine(matchLength < 10
                        ? $"ticket \"{ticket}\" - {matchLength}{winChar}"
                        : $"ticket \"{ticket}\" - {matchLength}{winChar} Jackpot!");

                    noMatch = false;

                    break;
                } 

                if (noMatch)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
