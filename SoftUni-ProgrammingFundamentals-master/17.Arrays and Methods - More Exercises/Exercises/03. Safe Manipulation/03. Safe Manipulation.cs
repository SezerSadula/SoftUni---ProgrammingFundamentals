using System;
using System.Linq;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Trim().Split(' ').ToArray();

            while (command[0] != "END")
            {
                PerformOperation(ref command, ref words);
                command = Console.ReadLine().Trim().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(", ", words));
        }

        private static void PerformOperation(ref string[] command, ref string[] words)
        {
            switch (command[0])
            {
                case "Reverse":
                    ReverseArray(ref words);
                    break;
                case "Distinct":
                    DeleteNonUniqueElements(ref words);
                    break;
                case "Replace":
                    if (VerifyIndex(command[1], words.Length - 1))
                    {
                        ReplaceElement(ref words, ref command);
                    }
                    else
                    {
                        PrintInvalidInputMessage();
                    }
                    break;
                default:
                    PrintInvalidInputMessage();
                    break;
            }
        }

        private static void PrintInvalidInputMessage()
        {
            Console.WriteLine("Invalid input!");
        }

        private static bool VerifyIndex(string indexString, int maxIndex)
        {
            int index = int.Parse(indexString);

            return index >= 0 && index <= maxIndex;
        }

        private static void ReplaceElement(ref string[] words, ref string[] command)
        {
            words[int.Parse(command[1])] = command[2];
        }

        private static void DeleteNonUniqueElements(ref string[] words)
        {
            words = words.Distinct().ToArray();
        }

        private static void ReverseArray(ref string[] words)
        {
            words = words.Reverse().ToArray();
        }
    }
}
