using System;
using System.Linq;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            var sum = 0M;

            while (true)
            {
                if (nums.Count <= 0)
                {
                    break;
                }

                var index = int.Parse(Console.ReadLine());

                var value = 0M;

                if (index < 0)
                {
                    index = 0;
                    value = nums[index];
                    nums[index] = nums[nums.Count - 1];
                }
                else if (index >= nums.Count)
                {
                    index = nums.Count - 1;
                    value = nums[index];
                    nums[index] = nums[0];

                }
                else
                {
                    value = nums[index];
                    nums.RemoveAt(index);
                }

                sum += value;

                for (var i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= value)
                    {
                        nums[i] += value;
                    }
                    else
                    {
                        nums[i] -= value;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
