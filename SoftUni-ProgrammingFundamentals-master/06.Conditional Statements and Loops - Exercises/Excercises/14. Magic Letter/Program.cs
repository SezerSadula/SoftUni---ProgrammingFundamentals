using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine().ToLower());
            char last = char.Parse(Console.ReadLine().ToLower());
            char stop = char.Parse(Console.ReadLine().ToLower());

            for (char c1 = first; c1 <= last; c1++)
            {
                if (c1 == stop)
                {
                    continue;
                }

                for (char c2 = first; c2 <= last; c2++)
                {
                    if (c2 == stop)
                    {
                        continue;
                    }

                    for (char c3 = first; c3 <= last; c3++)
                    {
                        if (c3 == stop)
                        {
                            continue;
                        }

                        Console.Write($"{c1}{c2}{c3} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
