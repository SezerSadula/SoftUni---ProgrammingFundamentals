using System;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    class Program
    {
        static void Main()
        {
            var mapString = Console.ReadLine();

            while (true)
            {
                var clues = Console.ReadLine().Split();

                var pattern = $@"\{clues[0]}{{{clues[1]},}}";

                var match = new Regex(pattern).Match(mapString);

                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                    break;
                }
            }
        }
    }
}
