using System;
using System.Linq;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main()
        {
            var startTime = Console.ReadLine()
                .Split(":".ToCharArray())
                .Select(ulong.Parse)
                .ToArray();

            var stepsToHome = ulong.Parse(Console.ReadLine());
            var secondsPerStep = ulong.Parse(Console.ReadLine());

            startTime[2] += stepsToHome * secondsPerStep;
            startTime[1] += startTime[2] / 60;
            startTime[2] %= 60;
            startTime[0] += startTime[1] / 60;
            startTime[1] %= 60;
            startTime[0] %= 24;

            Console.WriteLine($"Time Arrival: {startTime[0],0:D2}:{startTime[1],0:D2}:{startTime[2],0:D2}");
        }
    }
}
