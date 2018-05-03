using System;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine(num);
        }
    }
}
