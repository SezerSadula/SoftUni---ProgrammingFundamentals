using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Email_me
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"(.*)\@(.*)");

            var split = regex.Match(Console.ReadLine());

            var nameSum = split.Groups[1]
                .ToString()
                .Sum(ch => (int)ch);

            var domainSum = split.Groups[2]
                .ToString()
                .Sum(ch => (int)ch);

            Console.WriteLine(domainSum <= nameSum
                ? "Call her!"
                : "She is not the one.");
        }
    }
}
