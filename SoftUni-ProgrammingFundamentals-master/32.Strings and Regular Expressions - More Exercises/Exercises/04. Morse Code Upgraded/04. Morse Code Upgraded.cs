using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main()
        {
            var codedLetters = Console.ReadLine()
                .Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var regexOnes = new Regex(@"1");
            var regexZeros = new Regex(@"0");
            var regexSequences = new Regex(@"((0{2,})|(1{2,}))");

            var sb = new StringBuilder();

            foreach (var codedLetter in codedLetters)
            {
                var ones = regexOnes.Matches(codedLetter).Count;
                var zeros = regexZeros.Matches(codedLetter).Count;

                var code = ones * 5 + zeros * 3;

                var sequences = regexSequences.Matches(codedLetter);

                foreach (var sequence in sequences)
                {
                    code += sequence.ToString().Length;
                }

                sb.Append((char)code);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
