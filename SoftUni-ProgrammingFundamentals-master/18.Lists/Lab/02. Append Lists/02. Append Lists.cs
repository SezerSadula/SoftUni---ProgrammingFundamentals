using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine()
                .Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<long> nums = new List<long>();
            foreach (var list in lists)
            {
                nums.AddRange(list
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse));
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
