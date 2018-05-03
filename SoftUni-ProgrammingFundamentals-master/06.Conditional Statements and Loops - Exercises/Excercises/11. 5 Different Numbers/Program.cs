using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (end - start < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = start; i <= end; i++)
            {
                for (int j = i+1; j <= end; j++)
                {
                    for (int k = j+1; k <= end; k++)
                    {
                        for (int l = k+1; l <= end; l++)
                        {
                            for (int m = l+1; m <= end; m++)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
