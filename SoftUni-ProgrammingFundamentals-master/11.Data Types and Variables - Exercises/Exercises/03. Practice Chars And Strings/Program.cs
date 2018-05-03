using System;

namespace _03.Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char char1 = Console.ReadLine()[0];
            char char2 = char.Parse(Console.ReadLine());
            char char3 = Console.ReadLine().ToCharArray()[0];
            string str2 = Console.ReadLine();

            Console.WriteLine(str1);
            Console.WriteLine(char1);
            Console.WriteLine(char2);
            Console.WriteLine(char3);
            Console.WriteLine(str2);
        }
    }
}
