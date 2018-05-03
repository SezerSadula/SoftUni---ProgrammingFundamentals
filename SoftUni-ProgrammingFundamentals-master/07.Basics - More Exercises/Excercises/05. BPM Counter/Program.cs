using System;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0d, 1);

            int lengthInSecond = (int)(60.0d * beats / beatsPerMinute);
            
            Console.WriteLine($"{bars} bars - {lengthInSecond/60}m {lengthInSecond%60}s");
        }
    }
}
