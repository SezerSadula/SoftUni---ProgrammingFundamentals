using System;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int current_health = Int32.Parse(Console.ReadLine());
            int maximum_health = Int32.Parse(Console.ReadLine());
            int current_energy = Int32.Parse(Console.ReadLine());
            int maximum_energy = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new String('|', current_health), new String('.', maximum_health - current_health));
            Console.WriteLine("Energy: |{0}{1}|", new String('|', current_energy), new String('.', maximum_energy - current_energy));
        }
    }
}
