using System;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            long idMaxValue = 0;

            switch (idType)
            {
                case "sbyte":
                    idMaxValue = sbyte.MaxValue;
                    break;
                case "int":
                    idMaxValue = int.MaxValue;
                    break;
                case "long":
                    idMaxValue = long.MaxValue;
                    break;
            }

            long closestId = long.MinValue;

            byte count = byte.Parse(Console.ReadLine());
            for (byte line = 0; line < count; line++)
            {
                long id = long.Parse(Console.ReadLine());

                if (id > closestId && idMaxValue >= id)
                {
                    closestId = id;
                }
            }

            double delimiter = sbyte.MaxValue;
            if (closestId < 0)
            {
                delimiter = sbyte.MinValue;
            }

            long sentence = (long)Math.Ceiling(closestId / delimiter);

            string year = "year";
            if (sentence > 1)
            {
                year = "years";
            }

            Console.WriteLine($"Prisoner with id {closestId} is sentenced to {sentence} {year}");
        }
    }
}
