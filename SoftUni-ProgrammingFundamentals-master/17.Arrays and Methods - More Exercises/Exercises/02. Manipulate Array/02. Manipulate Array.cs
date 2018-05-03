using System;
using System.Linq;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            int operations = int.Parse(Console.ReadLine());

            for (int line = 0; line < operations; line++)
            {
                string[] command = Console.ReadLine().Trim().Split(' ').ToArray();

                PerformOperation(ref command, ref words);
            }

            Console.WriteLine(string.Join(", ", words));
        }

        private static void PerformOperation(ref string[] command, ref string[] words)
        {
            switch (command[0].ToLower())
            {
                case "reverse":
                    ReverseArray(ref words);
                    break;
                case "distinct":
                    DeleteNonUniqueElements(ref words);
                    break;
                case "replace":
                    ReplaceElement(ref words, ref command);
                    break;
            }
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
