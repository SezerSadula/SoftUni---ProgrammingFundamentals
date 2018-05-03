using System;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            var matches = Regex.Matches(
                Console.ReadLine(),
                @"(\b[A-Z][a-z]+ [A-Z][a-z]+\b)");

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
