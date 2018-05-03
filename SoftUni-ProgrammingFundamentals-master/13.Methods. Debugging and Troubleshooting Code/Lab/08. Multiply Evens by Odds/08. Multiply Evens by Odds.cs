using System;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = Math.Abs(long.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvensAndOdds(num));
        }

        static uint GetMultipleOfEvensAndOdds(long num)
        {
            uint evensSum = GetEvensSum(num);
            uint oddsSum = GetOddsSum(num);

            return oddsSum * evensSum;
        }

        static uint GetOddsSum(long num)
        {
            uint sum = 0;

            while (num > 0)
            {
                byte digit = (byte)(num % 10);
                num /= 10;

                if (digit % 2 == 1)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static uint GetEvensSum(long num)
        {
            uint sum = 0;

            while (num > 0)
            {
                byte digit = (byte)(num % 10);
                num /= 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}
