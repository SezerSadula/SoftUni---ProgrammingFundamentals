using System;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());

            string biggestKeg = "";
            double maxKegVolume = 0d;

            while (kegs > 0)
            {
                kegs--;
                string keg = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > maxKegVolume)
                {
                    maxKegVolume = volume;
                    biggestKeg = keg;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
