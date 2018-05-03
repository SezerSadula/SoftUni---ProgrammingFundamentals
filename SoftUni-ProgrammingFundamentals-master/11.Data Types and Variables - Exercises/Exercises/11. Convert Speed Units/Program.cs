using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distanceInMeters = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            uint timeInSeconds = seconds + minutes * 60U + hours * 60U * 60U;
            float speedMetersPerSecond = (float)distanceInMeters / timeInSeconds;
            float distanceInKm = (float) distanceInMeters / 1000f;

            float timeInHours = (float) timeInSeconds / 3600f;
            float speedKmPerHour = distanceInKm / timeInHours;

            float distanceInMiles = (float) distanceInMeters / 1609f;
            float speedMilesPerHour = distanceInMiles / timeInHours;

            Console.WriteLine($"{speedMetersPerSecond}");
            Console.WriteLine($"{speedKmPerHour}");
            Console.WriteLine($"{speedMilesPerHour}");
        }
    }
}
