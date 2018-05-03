using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(
                DateTime.ParseExact(Console.ReadLine(), 
                "d-M-yyyy", CultureInfo.InvariantCulture)
                .DayOfWeek);
        }
    }
}
