using System;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var patternLength = pattern.Length;
                var first = text.IndexOf(pattern, StringComparison.Ordinal);
                var last = text.LastIndexOf(pattern, StringComparison.Ordinal);

                if (first != -1 && last != -1
                    && first + patternLength <= last
                    && patternLength > 0)
                {
                    Console.WriteLine("Shaked it.");
                    text = text.Remove(last, patternLength);
                    text = text.Remove(first, patternLength);
                    pattern = pattern.Remove(patternLength / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}
