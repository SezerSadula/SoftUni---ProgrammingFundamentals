using System;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hour:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {GetSizeSring(ref size)}");
            Console.WriteLine($"Resolution: {width}x{height} ({GetOrientationString(ref width, ref height)})");
         }

        private static string GetOrientationString(ref int width, ref int height)
        {
            string orientation = "landscape";
            if (width == height)
            {
                orientation = "square";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }

            return orientation;
        }

        private static string GetSizeSring(ref int size)
        {
            string sizeStr;
            if (size < 1000)
            {
                sizeStr = size.ToString() + "B";
            }
            else if (size < 1000000)
            {
                sizeStr = (size / 1000.0d).ToString() + "KB";
            }
            else
            {
                sizeStr = Math.Round((size / 1000000.0d),1).ToString() + "MB";
            }

            return sizeStr;
        }
    }
}