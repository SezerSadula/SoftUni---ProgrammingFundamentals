using System;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int numbers = 0;
            while(int.TryParse(Console.ReadLine(), out num))
            {
                numbers++;
            }

            Console.WriteLine(numbers);
        }
    }
}
