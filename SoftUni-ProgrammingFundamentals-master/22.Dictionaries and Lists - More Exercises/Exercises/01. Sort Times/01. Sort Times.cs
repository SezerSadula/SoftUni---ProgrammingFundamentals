using System;
using System.Linq;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine()
                .Split()
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", times));
        }
    }
}
