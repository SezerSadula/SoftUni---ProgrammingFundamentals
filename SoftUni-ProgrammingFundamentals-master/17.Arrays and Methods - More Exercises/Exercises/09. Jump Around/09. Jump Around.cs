using System;
using System.Linq;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();

            long maxIndex = numbers.Length - 1;

            long sum = 0;
            long index = 0;
            
            while (true)
            {
                sum += numbers[index];

                long nextIndex = index + numbers[index];

                if (nextIndex <= maxIndex)
                {
                    index = nextIndex;
                    continue;
                }

                nextIndex = index - numbers[index];
                if (nextIndex >= 0)
                {
                    index = nextIndex;
                    continue;
                }

                break;
            }

            Console.WriteLine(sum);
        }
    }
}
