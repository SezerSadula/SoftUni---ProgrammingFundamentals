using System;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int openBrackets = 0;
            for (int i = 0; i < lines; i++)
            {
                string line = Console.ReadLine();

                if (line == "(")
                {
                    openBrackets++;
                }
                else if (line == ")")
                {
                    openBrackets--;
                }

                if (openBrackets < 0)
                {
                    break;
                }
            }

            if (openBrackets != 0)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
