using System;
using System.Linq;

namespace _07.Take_and_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();

            var take = message
                .ToCharArray()
                .Where(char.IsDigit)
                .Select(c => int.Parse(c.ToString()))
                .Where((value, index) => index % 2 == 0)
                .ToArray();

            var letters = message
                .ToCharArray()
                .Where(c => char.IsDigit(c) == false)
                .ToArray();

            var skip = message
                .ToCharArray()
                .Where(char.IsDigit)
                .Select(c => int.Parse(c.ToString()))
                .Where((value, index) => index % 2 == 1)
                .ToArray();

            var result = String.Empty;

            var lettersIndex = 0;
            for (int i = 0; i < take.Length; i++)
            {
                var takeCount = take[i];
                var skipCount = skip[i];

                result += new String(letters
                    .Skip(lettersIndex)
                    .Take(takeCount)
                    .ToArray());

                lettersIndex += takeCount + skipCount;
            }

            Console.WriteLine(result);
        }
    }
}
