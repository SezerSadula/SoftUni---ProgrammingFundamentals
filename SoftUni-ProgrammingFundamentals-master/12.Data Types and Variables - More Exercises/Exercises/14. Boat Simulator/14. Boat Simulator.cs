using System;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            byte firstDist = 0;
            byte secondDist = 0;

            int rounds = int.Parse(Console.ReadLine());
            for (int round = 0; round < rounds; round++)
            {
                string command = Console.ReadLine();

                if (command == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }

                byte dist = (byte)command.Length;
                if (round % 2 == 0)
                {
                    firstDist += dist;
                    if (firstDist >= 50)
                    {
                        Console.WriteLine(firstBoat);
                        return;
                    }
                }
                else
                {
                    secondDist += dist;
                    if (secondDist >= 50)
                    {
                        Console.WriteLine(secondBoat);
                        return;
                    }
                }
            }

            Console.WriteLine(firstDist >= secondDist ? firstBoat : secondBoat);
        }
    }
}
