using System;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte priceOne;

            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            long totalCost = 0;
            if (sbyte.TryParse(firstNum, out priceOne))
            {
                totalCost = long.Parse(secondNum) * 10 + priceOne * 4;
            }
            else
            {
                totalCost = long.Parse(firstNum) * 10 + sbyte.Parse(secondNum) * 4;
            }

            Console.WriteLine(totalCost);
        }
    }
}
