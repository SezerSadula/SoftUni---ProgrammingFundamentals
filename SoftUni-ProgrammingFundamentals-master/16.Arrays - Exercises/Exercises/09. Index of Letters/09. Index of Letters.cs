using System;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] alphabetSamllLetters = new char[26];

            int index = 0;
            for (int chr = 'a'; chr <= 'z'; chr++)
            {
                alphabetSamllLetters[index++] = (char)chr;
            }

            for (int letter = 0; letter < word.Length; letter++)
            {
                Console.WriteLine($"{word[letter]} -> {Array.IndexOf(alphabetSamllLetters, word[letter])}");
            }
        }
    }
}
