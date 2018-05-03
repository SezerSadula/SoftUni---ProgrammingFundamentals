using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = 
                new Dictionary<string, SortedDictionary<string, int[]>>();

            var lines = int.Parse(Console.ReadLine());

            while (lines-- > 0)
            {
                var dragon = Console.ReadLine()
                    .Split()
                    .ToArray();

                var type = dragon[0];
                var name = dragon[1];

                var stats = new int[3]; // damage, health, armor
                stats[0] = dragon[2].Equals("null") ?
                    45 : int.Parse(dragon[2]);
                stats[1] = dragon[3].Equals("null") ?
                    250 : int.Parse(dragon[3]);
                stats[2] = dragon[4].Equals("null") ? 
                    10 : int.Parse(dragon[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, int[]>();
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new int[3];
                }

                dragons[type][name] = stats;
            }

            foreach (var dragonType in dragons)
            {
                var avrgDamage = dragonType
                    .Value
                    .Values
                    .Select(x => x[0])
                    .Average();
                var avrgHealth = dragonType
                    .Value
                    .Values
                    .Select(x => x[1])
                    .Average();
                var avrgArmor = dragonType
                    .Value
                    .Values
                    .Select(x => x[2])
                    .Average();

                Console.WriteLine($"{dragonType.Key}::({avrgDamage:F2}/{avrgHealth:F2}/{avrgArmor:F2})");

                foreach (var dragon in dragonType.Value)
                {
                    var name = dragon.Key;
                    var damage = dragon.Value[0];
                    var health = dragon.Value[1];
                    var armor = dragon.Value[2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
