using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int neededQuantity = 250;

            var keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };

            var junkMaterials = new SortedDictionary<string, int>();

            while (true)
            {
                var batch = Console.ReadLine()
                    .Split()
                    .ToArray();

                var length = batch.Length;

                for (int i = 0; i < length; i += 2)
                {
                    var quantity = int.Parse(batch[i]);
                    var material = batch[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= neededQuantity)
                        {
                            PrintResult(neededQuantity, keyMaterials, 
                                junkMaterials, material);
                            return;
                        }

                        continue;
                    }

                    if (!junkMaterials.ContainsKey(material))
                    {
                        junkMaterials[material] = 0;
                    }

                    junkMaterials[material] += quantity;
                }
            }
        }

        private static void PrintResult(int neededQuantity, 
            Dictionary<string, int> keyMaterials, 
            SortedDictionary<string, int> junkMaterials, 
            string material)
        {
            var item = String.Empty;
            switch (material)
            {
                case "shards":
                    item = "Shadowmourne";
                    break;
                case "fragments":
                    item = "Valanyr";
                    break;
                case "motes":
                    item = "Dragonwrath";
                    break;
            }
            Console.WriteLine($"{item} obtained!");

            keyMaterials[material] -= neededQuantity;

            var result = keyMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Concat(junkMaterials)
                .ToArray();

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
