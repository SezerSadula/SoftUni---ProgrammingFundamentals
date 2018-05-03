using System;
using System.Linq;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bombSpecs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var bombNum = bombSpecs[0];
            var bombPower = bombSpecs[1];

            for (int index = 0; index < numbers.Count; index++)
            {
                if (numbers[index] == bombNum)
                {
                    var startIndex = Math.Max(index - bombPower, 0);
                    var endIndex = Math.Min(index + bombPower, numbers.Count - 1);
                    var count = endIndex - startIndex + 1;

                    numbers.RemoveRange(startIndex, count);

                    index = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
