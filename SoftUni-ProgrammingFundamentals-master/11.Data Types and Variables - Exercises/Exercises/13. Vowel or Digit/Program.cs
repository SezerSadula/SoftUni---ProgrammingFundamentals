using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
                return;
            }

            if ("aeiouAEIOU".Contains(symbol.ToString()))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
