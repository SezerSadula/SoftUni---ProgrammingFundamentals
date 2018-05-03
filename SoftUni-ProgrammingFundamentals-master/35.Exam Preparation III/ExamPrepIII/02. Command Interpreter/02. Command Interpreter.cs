using System;
using System.Linq;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(x => x.Trim())
                .ToList();

            while (true)
            {
                var tokens = Console.ReadLine().Split();

                if ("end".Equals(tokens[0]))
                {
                    break;
                }

                var error = false;

                switch (tokens[0])
                {
                    case "reverse":
                        {
                            var start = int.Parse(tokens[2]);
                            var count = int.Parse(tokens[4]);

                            if (InBounds(start, count, arr.Count))
                            {
                                arr.Reverse(start, count);
                            }
                            else
                            {
                                error = true;
                            }

                            break;
                        }
                    case "sort":
                        {
                            var start = int.Parse(tokens[2]);
                            var count = int.Parse(tokens[4]);

                            if (InBounds(start, count, arr.Count))
                            {
                                arr.Sort(start, count, null);
                            }
                            else
                            {
                                error = true;
                            }

                            break;
                        }
                    case "rollLeft":
                        {
                            var count = int.Parse(tokens[1]) % arr.Count;

                            if (count >= 0)
                            {
                                arr = arr.Skip(count).Take(arr.Count - count)
                                    .Concat(arr.Take(count))
                                    .ToList();
                            }
                            else
                            {
                                error = true;
                            }

                            break;
                        }
                    case "rollRight":
                        {
                            var count = int.Parse(tokens[1]) % arr.Count;

                            if (count >= 0)
                            {
                                arr = arr.Skip(arr.Count - count).Take(count)
                                    .Concat(arr.Take(arr.Count - count))
                                    .ToList();
                            }
                            else
                            {
                                error = true;
                            }

                            break;
                        }
                }

                if (error)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static bool InBounds(int start, int count, int limit)
        {
            return start >= 0 && start < limit &&
                   count >= 0 && (count + start) <= limit;
        }
    }
}
