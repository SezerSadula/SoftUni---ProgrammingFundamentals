using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var first = input[0];
            var second = input[1];

            if (input[0].Length > input[1].Length)
            {
                first = input[1];
                second = input[0];
            }

            var charMap = new Dictionary<char, char>();
            var result = true;

            for (var i = 0; i < first.Length; i++)
            {
                if (!charMap.ContainsKey(first[i]))
                {
                    if (charMap.ContainsValue(second[i]))
                    {
                        result = false;
                        break;
                    }

                    charMap.Add(first[i], second[i]);
                }
                else if (charMap[first[i]] != second[i])
                {
                    result = false;
                    break;
                }
            }

            var diff = second.Length - first.Length;
            if (diff > 0)
            {
                for (var i = first.Length; i < second.Length; i++)
                {
                    if (!charMap.ContainsValue(second[i]))
                    {
                        result = false;
                        break;
                    }
                }
            }

            Console.WriteLine(result.ToString().ToLower());
        }
    }
}
