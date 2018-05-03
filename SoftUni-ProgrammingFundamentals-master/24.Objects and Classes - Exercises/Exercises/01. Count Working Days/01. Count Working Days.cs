using System;
using System.Globalization;
using System.Linq;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string dateFormat = "dd-MM-yyyy";
            DateTime startDate = DateTime.ParseExact(
                Console.ReadLine(), dateFormat, provider);
            DateTime endDate = DateTime.ParseExact(
                Console.ReadLine(), dateFormat, provider);

            var workingDays = 0;
            while (startDate <= endDate)
            {
                if (IsWorkingDay(startDate))
                {
                    workingDays++;
                }
                startDate = startDate.AddDays(1);
            }

            Console.WriteLine(workingDays);
        }

        static bool IsWorkingDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday
                || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            return !IsOfficialHoliday(date);
        }

        private static bool IsOfficialHoliday(DateTime date)
        {
            string dateString = $"{date.Day}-{date.Month}";
            string[] holidays = {"1-1", "3-3", "1-5",
                "6-5", "24-5", "6-9", "22-9", "1-11",
                "24-12", "25-12", "26-12"};

            return holidays.Contains(dateString);
        }
    }
}
