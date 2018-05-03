using System;
using System.Linq;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());

            var field = new int[fieldSize];

            var bugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x < fieldSize)
                .ToArray();

            foreach (var bug in bugs)
            {
                field[bug] = 1;
            }

            while (true)
            {
                var command = Console.ReadLine();

                if ("end".Equals(command))
                {
                    break;
                }

                var tokens = command.Split();

                var index = int.Parse(tokens[0]);

                if (index < 0 || index >= fieldSize || field[index] == 0)
                {
                    continue;
                }

                field[index] = 0;

                var fly = int.Parse(tokens[2]);

                if ("left".Equals(tokens[1]))
                {
                    fly = -fly;
                }

                var moveTo = index + fly;

                while (true)
                {
                    if (moveTo < 0 || moveTo >= fieldSize)
                    {
                        break;
                    }

                    if (field[moveTo] == 0)
                    {
                        field[moveTo] = 1;
                        break;
                    }

                    moveTo += fly;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
