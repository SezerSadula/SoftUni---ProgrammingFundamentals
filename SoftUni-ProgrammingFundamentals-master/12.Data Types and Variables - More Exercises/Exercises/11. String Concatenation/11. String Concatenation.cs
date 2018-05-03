using System;
using System.Collections.Generic;
using System.Text;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());

            int mask = ("even" == Console.ReadLine()) ? 0 : 1;

            int lines = int.Parse(Console.ReadLine());

            Queue<string> words = new Queue<string>();
            for (int i = 1; i <= lines; i++)
            {
                string word = Console.ReadLine();

                if (i % 2 == mask)
                {
                    words.Enqueue(word);
                }
            }

            StringBuilder sb = new StringBuilder(words.Dequeue());

            while (words.Count > 0)
            {
                sb.Append(delimiter);
                sb.Append(words.Dequeue());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
