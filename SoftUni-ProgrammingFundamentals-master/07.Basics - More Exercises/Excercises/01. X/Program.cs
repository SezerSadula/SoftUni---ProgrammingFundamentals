using System;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine(new string(' ', n / 2) + "x" + new string(' ', n / 2));
                }
                else
                {
                    int leftSpaces = 0;
                    int middleSpaces = 0;
                    if (i < n / 2 )
                    {
                        leftSpaces = i;
                        middleSpaces = n - 2 - leftSpaces * 2;
                    }
                    else
                    {
                        leftSpaces =  n - i - 1;
                        middleSpaces = n - leftSpaces * 2 - 2;
                    }
                    Console.WriteLine(new string(' ', leftSpaces) + "x"
                                        + new string(' ', middleSpaces) + "x");
                }
            }
        }
    }
}
