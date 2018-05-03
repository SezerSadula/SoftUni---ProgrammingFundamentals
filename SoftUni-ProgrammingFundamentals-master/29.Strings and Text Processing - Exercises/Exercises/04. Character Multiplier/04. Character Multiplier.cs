using System;
using System.Linq;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var first = input[0];
            var second = input[1];

            var common = Math.Min(first.Length, second.Length);

            var result = 0UL;

            for (var i = 0; i < common; i++)
            {
                result += (ulong)(first[i] * second[i]);
            }

            var diff = first.Length - second.Length;

            if (diff > 0)
            {
                for (var i = second.Length; i < first.Length; i++)
                {
                    result += first[i];
                }
            }
            else if (diff < 0)
            {
                for (var i = first.Length; i < second.Length; i++)
                {
                    result += second[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
