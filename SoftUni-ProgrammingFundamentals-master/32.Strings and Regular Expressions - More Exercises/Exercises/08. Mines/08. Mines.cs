using System;
using System.Text.RegularExpressions;

namespace _08.Mines
{
    class Program
    {
        static void Main()
        {
            var mineField = Console.ReadLine();

            var matches = new Regex(@"\<\w{2}\>")
                .Matches(mineField);

            for (var i = 0; i < matches.Count; i++)
            {
                var power = Math.Abs(matches[i].Value[1] - matches[i].Value[2]);

                var start = Math.Max(0, matches[i].Index - power);

                var end = Math.Min(mineField.Length,
                    matches[i].Index + power + matches[i].Length);

                var len = end - start;

                mineField = mineField
                    .Remove(start, len)
                    .Insert(start, new string('_', len));
            }

            Console.WriteLine(mineField);
        }
    }
}
