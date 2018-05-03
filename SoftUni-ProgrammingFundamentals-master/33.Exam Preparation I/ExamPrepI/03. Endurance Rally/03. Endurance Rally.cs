using System;
using System.Linq;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main()
        {
            var drivers = Console.ReadLine()
                .Split();

            var trackZones = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkPoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var driver in drivers)
            {
                double currentFluel = driver[0];

                for (var i = 0; i < trackZones.Length; i++)
                {
                    currentFluel += checkPoints.Contains(i) 
                        ? trackZones[i] 
                        : -trackZones[i];

                    if (currentFluel > 0d)
                    {
                        continue;
                    }

                    Console.WriteLine($"{driver} - reached {i}");
                    break;
                }

                if (currentFluel > 0d)
                {
                    Console.WriteLine($"{driver} - fuel left {currentFluel:F2}");
                }
            }
        }
    }
}
