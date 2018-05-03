using System;
using System.Text;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string numString = Console.ReadLine();

            StringBuilder fitString = new StringBuilder();
            fitString.Append(numString + " can fit in:\n");

            bool canFit = false;

            try
            {
                sbyte test = sbyte.Parse(numString);
                canFit = true;
                fitString.Append("* sbyte\n");
            }
            catch { }

            try
            {
                byte test = byte.Parse(numString);
                canFit = true;
                fitString.Append("* byte\n");
            }
            catch { }

            try
            {
                short test = short.Parse(numString);
                canFit = true;
                fitString.Append("* short\n");
            }
            catch { }

            try
            {
                ushort test = ushort.Parse(numString);
                canFit = true;
                fitString.Append("* ushort\n");
            }
            catch { }

            try
            {
                int test = int.Parse(numString);
                canFit = true;
                fitString.Append("* int\n");
            }
            catch { }

            try
            {
                uint test = uint.Parse(numString);
                canFit = true;
                fitString.Append("* uint\n");
            }
            catch { }

            try
            {
                long test = long.Parse(numString);
                canFit = true;
                fitString.Append("* long\n");
            }
            catch { }

            if (canFit)
            {
                Console.WriteLine(fitString);
            }
            else
            {
                Console.WriteLine($"{numString} can't fit in any type");
            }
        }
    }
}
