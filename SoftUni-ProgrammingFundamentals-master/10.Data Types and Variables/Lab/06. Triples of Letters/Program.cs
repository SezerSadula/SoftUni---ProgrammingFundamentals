using System;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char start = 'a';
            char end = (char)((int)start + n);

            for (char i = start; i < end; i++)
            {
                for (char j = start; j < end; j++)
                {
                    for (char k = start; k < end; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
