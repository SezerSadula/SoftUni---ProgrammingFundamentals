using System;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var keyword = Console.ReadLine().ToLower();

            var occurrencies = 0;
            var index = 0;

            while ((index = text.IndexOf(keyword, index)) != -1)
            {
                index++;
                occurrencies++;
            }

            Console.WriteLine(occurrencies);
        }
    }
}
