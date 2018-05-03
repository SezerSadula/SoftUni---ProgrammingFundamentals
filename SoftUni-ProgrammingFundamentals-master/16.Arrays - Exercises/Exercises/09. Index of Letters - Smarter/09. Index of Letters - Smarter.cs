using System;

namespace _09.Index_of_Letters___Smarter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charsOfWord = Console.ReadLine().ToCharArray();

            foreach (var letter in charsOfWord)
            {
                Console.WriteLine($"{letter} -> {letter - 'a'}");
            }
        }
    }
}
