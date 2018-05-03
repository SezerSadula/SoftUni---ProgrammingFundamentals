using System;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort availableCapacity = 255;

            byte lines = byte.Parse(Console.ReadLine());

            for (byte line = 0; line < lines; line++)
            {
                ushort litres = ushort.Parse(Console.ReadLine());

                if (availableCapacity >= litres)
                {
                    availableCapacity -= litres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(255 - availableCapacity);
        }
    }
}
