using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    class Program
    {
        static void Main()
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, ulong>>();

            var filesToRead = int.Parse(Console.ReadLine());

            while (filesToRead-- > 0)
            {
                var entry = Console.ReadLine().Split('\\');

                var root = entry.First();
                var fileName = entry.Last().Split(';').First();
                var fileSize = ulong.Parse(entry.Last().Split(';').Last());

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, ulong>());
                }

                filesByRoot[root][fileName] = fileSize;
            }

            var search = Console.ReadLine().Split();

            var found = false;

            if (filesByRoot.ContainsKey(search.Last()))
            {
                var sorted = filesByRoot[search.Last()]
                    .Where(x => x.Key.EndsWith(search.First()))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                if (sorted.Count > 0)
                {
                    found = true;

                    foreach (var fileEntry in sorted)
                    {
                        Console.WriteLine($"{fileEntry.Key} - {fileEntry.Value} KB");
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
