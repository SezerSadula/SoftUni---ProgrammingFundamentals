using System;
using System.Linq;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] pricesArray = Console.ReadLine()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();

            long expences = 0;
            long loot = 0;

            string roundDataString = Console.ReadLine();

            while (roundDataString != "Jail Time")
            {
                string [] roundData = roundDataString
                    .Split(' ')
                    .ToArray();

                expences += long.Parse(roundData[1]);

                loot += roundData[0].Count(c => c == '%') * pricesArray[0];
                loot += roundData[0].Count(c => c == '$') * pricesArray[1];

                roundDataString = Console.ReadLine();
            }

            long heistResult = loot - expences;

            if (heistResult >= 0L)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {heistResult}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {-heistResult}.");
            }
 
        }
    }
}

