using System;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            for (int i = 0; i < 4; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{nums[0]:D4} {nums[1]:D4} {nums[2]:D4} {nums[3]:D4}");
        }
    }
}
