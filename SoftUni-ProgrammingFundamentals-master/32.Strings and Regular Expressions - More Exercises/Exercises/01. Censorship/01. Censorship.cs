using System;
using System.Text.RegularExpressions;

namespace _01.Censorship
{
    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            Console.WriteLine(new Regex(word)
                .Replace(text, new string('*', word.Length)));
        }
    }
}
