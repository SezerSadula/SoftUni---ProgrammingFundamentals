using System;
using System.Linq;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat($"{i.ToString()} ", i).ToArray()));
            }
        }
    }
}
