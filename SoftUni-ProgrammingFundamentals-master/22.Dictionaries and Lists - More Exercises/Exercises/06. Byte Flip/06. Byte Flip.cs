using System;
using System.Linq;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Select(x => new string(x.ToCharArray().Reverse().ToArray()))
                .Select(x => Convert.ToInt32(x, 16))
                .Select(x => (char)x)
                .Reverse()
                .ToArray();

            Console.WriteLine(nums);
        }
    }
}
