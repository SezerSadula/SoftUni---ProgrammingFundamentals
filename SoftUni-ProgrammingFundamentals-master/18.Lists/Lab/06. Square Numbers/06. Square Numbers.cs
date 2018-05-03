using System;
using System.Linq;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .Where(num => Math.Sqrt(num) == (int) Math.Sqrt(num))
                .ToList();

            Console.WriteLine(string.Join(" ", 
                numbers.OrderByDescending(x => x).ToList()));
        }
    }
}
