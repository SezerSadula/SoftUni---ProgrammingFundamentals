using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            long currentHealth = health;

            var knownViruses = new HashSet<string>();
            var virus = Console.ReadLine();

            while (!virus.Equals("end"))
            {
                var virusStrength = virus
                    .ToCharArray()
                    .Select(x => (int)x)
                    .Sum() / 3;

                var virusDefeatSeconds = virusStrength * virus.Length;

                if (knownViruses.Contains(virus))
                {
                    virusDefeatSeconds /= 3;
                }
                else
                {
                    knownViruses.Add(virus);
                }

                Console.WriteLine($"Virus {virus}: {virusStrength} => {virusDefeatSeconds} seconds");

                currentHealth -= virusDefeatSeconds;

                if (currentHealth > 0)
                {
                    Console.WriteLine($"{virus} defeated in {virusDefeatSeconds/60}m {virusDefeatSeconds%60}s.");
                    Console.WriteLine($"Remaining health: {currentHealth}");
                    currentHealth = Math.Min((int) (currentHealth * 1.2), health);
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                virus = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}
