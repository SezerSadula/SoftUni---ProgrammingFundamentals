using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFilePathAndName = "../../sample_text.txt";
            const string outputFilePathAndName = "../../result_text.txt";

            var punctuations = ".,!?:".ToCharArray();

            var textArray = File.ReadAllText(inputFilePathAndName).ToCharArray();

            var result = new List<char>();

            foreach (var ch in textArray)
            {
                if (!punctuations.Contains(ch))
                {
                    result.Add(ch);
                }
            }

            File.Delete(outputFilePathAndName);

            File.WriteAllText(outputFilePathAndName, string.Join("", result));
        }
    }
}
