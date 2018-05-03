using System;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int attackPesho = int.Parse(Console.ReadLine());
            int attackGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho= 100;

            int round = 0;

            while (true)
            {
                round++;

                int hits, healthRemaining;
                string attacker, defender, attack;
                bool winner = false;

                if (round % 2 == 0)
                {
                    attacker = "Gosho";
                    defender = "Pesho";
                    attack = "Thunderous fist";
                    hits = attackGosho;
                    healthPesho -= hits;
                    healthRemaining = healthPesho;
                }
                else
                {
                    attacker = "Pesho";
                    defender = "Gosho";
                    attack = "Roundhouse kick";
                    hits = attackPesho;
                    healthGosho -= hits;
                    healthRemaining = healthGosho;
                }

                if (healthRemaining <= 0)
                {
                    Console.WriteLine($"{attacker} won in {round}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{attacker} used {attack} and reduced {defender} to {healthRemaining} health.");
                }

                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        }
    }
}
