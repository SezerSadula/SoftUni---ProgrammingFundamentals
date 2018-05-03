using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = ".,:;()[]\"'\\/!? ".ToCharArray();

            var words = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
