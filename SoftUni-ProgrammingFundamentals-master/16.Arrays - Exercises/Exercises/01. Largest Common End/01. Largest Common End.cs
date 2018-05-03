using System;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int elementsToCheck = (firstArr.Length < secondArr.Length) ? firstArr.Length : secondArr.Length;
            int maxEqualElements = 0;

            for (int i = 0; i < elementsToCheck; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    maxEqualElements++;
                    continue;
                }

                break;
            }

            int currentEqualElements = 0;
            for (int i = 1; i <= elementsToCheck; i++)
            {
                if (firstArr[firstArr.Length - i] == secondArr[secondArr.Length - i])
                {
                    currentEqualElements++;
                    continue;
                }

                break;
            }

            if (currentEqualElements > maxEqualElements)
            {
                maxEqualElements = currentEqualElements;
            }

            Console.WriteLine(maxEqualElements);
        }
    }
}
