using System;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayNumber = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(days[--dayNumber]);
            }
            catch
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
