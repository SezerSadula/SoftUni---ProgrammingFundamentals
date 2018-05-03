using System;
using System.Collections.Generic;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < 3; i++)
            {
                chars.Push(char.Parse(Console.ReadLine()));
            }

            while (chars.Count > 0)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}
