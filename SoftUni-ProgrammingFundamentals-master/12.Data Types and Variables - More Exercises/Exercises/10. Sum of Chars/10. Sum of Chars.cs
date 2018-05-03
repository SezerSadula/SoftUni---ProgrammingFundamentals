using System;

namespace _10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            uint sum = 0;
            while (lines > 0)
            {
                lines--;

                sum += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
