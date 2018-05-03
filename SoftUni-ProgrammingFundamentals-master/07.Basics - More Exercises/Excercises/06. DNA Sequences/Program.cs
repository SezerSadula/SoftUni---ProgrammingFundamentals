using System;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicSum = int.Parse(Console.ReadLine());

            char[] acids = {'A', 'C', 'G', 'T'};
            int[] values = {1, 2, 3, 4};
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        counter++;

                        if (values[i] + values[j] + values[k] >= magicSum)
                        {
                            Console.Write("O" + acids[i] + acids[j] + acids[k] + "O ");
                        }
                        else
                        {
                            Console.Write("X" + acids[i] + acids[j] + acids[k] + "X ");
                        }

                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
