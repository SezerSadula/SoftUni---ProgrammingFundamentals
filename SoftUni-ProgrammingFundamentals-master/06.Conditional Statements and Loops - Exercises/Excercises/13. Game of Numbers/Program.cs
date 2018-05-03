using System;
using System.Collections.Generic;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();

            int combinations = 0;

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    combinations++;
                    if (i + j == magic)
                    {
                        stack.Push(new Tuple<int, int>(i,j));
                    }
                }
            }

            if (stack.Count > 0)
            {
                Tuple<int, int> last = stack.Pop();

                Console.WriteLine($"Number found! {last.Item1} + {last.Item2} = {magic}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magic}");
            }
        }
    }
}
