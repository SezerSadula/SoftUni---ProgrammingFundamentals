using System;
using System.Text;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            byte key = byte.Parse(Console.ReadLine());

            int lines = int.Parse(Console.ReadLine());

            while (lines > 0)
            {
                lines--;
                sb.Append((char)(char.Parse(Console.ReadLine()) + key));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
