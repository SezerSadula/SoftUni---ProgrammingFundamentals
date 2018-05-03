using System;
using System.Text;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("The word is: ");

            int characters = int.Parse(Console.ReadLine());

            for (int i = 0; i < characters; i++)
            {
                sb.Append(char.Parse(Console.ReadLine()));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
