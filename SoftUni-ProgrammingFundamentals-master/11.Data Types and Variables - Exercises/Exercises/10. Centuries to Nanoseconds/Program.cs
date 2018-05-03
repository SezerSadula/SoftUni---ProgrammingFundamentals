using System;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centures = byte.Parse(Console.ReadLine());

            ushort years = (ushort) (centures * 100);
            uint days = (uint) (years * 365.2422d);
            uint hours = days * 24U;
            uint minutes = hours * 60U;
            ulong seconds = minutes * 60UL;
            ulong milliseconds = seconds * 1000UL;
            ulong microseconds = milliseconds * 1000UL;
            decimal nanoseconds = microseconds * 1000M;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
