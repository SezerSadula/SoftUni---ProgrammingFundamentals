using System;
using System.Linq;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                string.Concat(
                Console.ReadLine()
                .Select(ch => $"\\u{Convert.ToUInt16(ch):x4}")
                .ToList()));
        }
    }
}
