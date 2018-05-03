using System;
using System.Text;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooterRow(n);
            PrintMiddleRows(n);
            PrintHeaderFooterRow(n);
        }

        static void PrintMiddleRows(int n)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-");
            for (int i = 1; i < n ; i++)
            {
                sb.Append("\\/");
            }
            sb.Append("-");

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(sb.ToString());
            }
        }

        static void PrintHeaderFooterRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
