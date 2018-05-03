using System;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width}x{height} => {Math.Round(width * height / 1000000.0d, 1)}MP");
        }
    }
}
