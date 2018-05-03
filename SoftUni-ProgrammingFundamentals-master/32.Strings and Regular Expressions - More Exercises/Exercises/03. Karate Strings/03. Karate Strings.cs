using System;
using System.Text;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder(Console.ReadLine());

            var kick = 0;

            for (var i = 0; i < sb.Length; i++)
            {
                if (sb[i] != '>')
                {
                    continue;
                }

                i++;

                kick += sb[i] - '0';

                while (i < sb.Length && kick > 0)
                {
                    if (sb[i] == '>')
                    {
                        break;
                    }

                    sb.Remove(i, 1);

                    kick--;
                }

                i--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
