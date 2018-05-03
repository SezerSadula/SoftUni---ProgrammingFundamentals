using System;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main()
        {
            var nPower = int.Parse(Console.ReadLine());
            var mDistance = int.Parse(Console.ReadLine());
            var yExhaustion = int.Parse(Console.ReadLine());

            var c = nPower / 2;

            if (nPower % 2 != 0 || yExhaustion == 0)
            {
                c = int.MinValue;
            }

            var count = 0;

            while (nPower >= mDistance)
            {
                nPower -= mDistance;

                count++;

                if (nPower == c)
                {
                    nPower /= yExhaustion;
                }
            }

            Console.WriteLine(nPower);
            Console.WriteLine(count);
        }
    }
}
