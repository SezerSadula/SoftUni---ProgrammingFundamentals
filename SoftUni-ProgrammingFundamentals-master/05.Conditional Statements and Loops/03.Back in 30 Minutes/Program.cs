using System;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            const int added_minutes = 30;

            minutes += added_minutes;

            if (minutes >=60)
            {
                hours += minutes / 60;
                minutes = minutes % 60;
            }

            if (hours >= 24)
            {
                hours %= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
