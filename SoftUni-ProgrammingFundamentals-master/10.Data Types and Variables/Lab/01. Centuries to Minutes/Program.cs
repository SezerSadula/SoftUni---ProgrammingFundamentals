using System;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centures = uint.Parse(Console.ReadLine());

            uint years = centures * 100U;
            uint days = (uint)(years * 365.2422d);
            uint hours = days * 24U;
            ulong minutes = hours * 60UL;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
