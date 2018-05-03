using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var minedResources = new Dictionary<string, long>();

            var resource = Console.ReadLine();

            while (!resource.Equals("stop"))
            {
                if (!minedResources.ContainsKey(resource))
                {
                    minedResources[resource] = 0L;
                }

                minedResources[resource] += long.Parse(Console.ReadLine());

                resource = Console.ReadLine();
            }

            foreach (var minedResource in minedResources)
            {
                Console.WriteLine($"{minedResource.Key} -> {minedResource.Value}");
            }
        }
    }
}
