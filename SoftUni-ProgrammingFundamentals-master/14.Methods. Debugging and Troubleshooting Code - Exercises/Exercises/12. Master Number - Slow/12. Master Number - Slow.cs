using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = ulong.Parse(Console.ReadLine());

            var masterNumbers = new List<ulong>();
            for (ulong num = 1; num <= range; num++)
            {
                if (IsMasterNumber(num))
                {
                    masterNumbers.Add(num);
                }
            }

            Console.WriteLine(string.Join("\n", masterNumbers));
        }

        private static bool IsMasterNumber(ulong num)
        {
            var digits = num.ToString()
                .ToCharArray()
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            return IsSymmetric(digits) 
                && SumIsDivisibleBy7(digits) 
                && HasEvenDigit(digits);
        }

        private static bool HasEvenDigit(IEnumerable<int> digits)
        {
            return digits.Any(number => number % 2 == 0);
        }

        private static bool SumIsDivisibleBy7(IEnumerable<int> digits)
        {
            return digits.Sum() % 7 == 0;
        }

        private static bool IsSymmetric(IEnumerable<int> digits)
        {
            return digits.SequenceEqual(digits.Reverse());
        }
    }
}
