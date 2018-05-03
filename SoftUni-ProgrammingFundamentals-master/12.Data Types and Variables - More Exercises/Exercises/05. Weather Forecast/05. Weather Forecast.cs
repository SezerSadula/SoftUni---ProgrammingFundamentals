using System;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte b;
            int integer;
            long lng;

            string numberString = Console.ReadLine();
            if (sbyte.TryParse(numberString, out b))
            {
                Console.WriteLine("Sunny");
            }
            else if(int.TryParse(numberString, out integer))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(numberString, out lng))
            {
                Console.WriteLine("Windy");
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
