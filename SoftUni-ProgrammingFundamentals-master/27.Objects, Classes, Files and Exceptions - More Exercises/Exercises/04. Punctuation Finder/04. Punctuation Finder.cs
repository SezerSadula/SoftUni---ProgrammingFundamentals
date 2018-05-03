using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePathAndName = "../../sample_text.txt";
            var punctuations = ".,!?:".ToCharArray();

            var textArray = File.ReadAllText(filePathAndName).ToCharArray();

            var result = new List<char>();

            foreach (var ch in textArray)
            {
                if (punctuations.Contains(ch))
                {
                    result.Add(ch);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
