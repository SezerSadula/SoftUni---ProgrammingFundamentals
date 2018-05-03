using System;

namespace _02.Randomize_Words
{
    internal class Program
    {
        private static void Main()
        {
            var words = Console.ReadLine()
                .Split();

            var rnd = new Random();

            for (var i = 0; i < words.Length; i++)
            {
                var temp = words[i];
                var randomIndex = rnd.Next(words.Length);
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
