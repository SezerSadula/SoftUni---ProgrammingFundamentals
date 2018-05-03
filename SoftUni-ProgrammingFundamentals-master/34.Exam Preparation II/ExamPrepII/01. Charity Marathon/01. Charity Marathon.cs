using System;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            var durationDays = decimal.Parse(Console.ReadLine());
            var runners = decimal.Parse(Console.ReadLine());
            var avrgLapsPerRunner = decimal.Parse(Console.ReadLine());
            var lapLengthM = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var actualRunners = Math.Min(runners, durationDays * trackCapacity);

            var money = actualRunners * avrgLapsPerRunner * lapLengthM / 1000 * moneyPerKm;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
