using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files___Solution_with_a_Class
{
    class Program
    {
        static void Main()
        {
            var filesByRoot = new Dictionary<string, List<FileEntry>>();

            var filesToRead = int.Parse(Console.ReadLine());

            while (filesToRead-- > 0)
            {
                var entry = FileEntry.Parse(Console.ReadLine());

                if (!filesByRoot.ContainsKey(entry.Root))
                {
                    filesByRoot.Add(entry.Root, new List<FileEntry>());
                }

                if (filesByRoot[entry.Root].Contains(entry))
                {
                    filesByRoot[entry.Root].Remove(entry);
                }

                filesByRoot[entry.Root].Add(entry);
            }

            var search = Console.ReadLine().Split();

            List<FileEntry> result = Enumerable.Empty<FileEntry>().ToList<FileEntry>();

            if (filesByRoot.ContainsKey(search[2]))
            {
                result = filesByRoot[search[2]]
                    .Where(x => x.Extension == search[0])
                    .OrderByDescending(x => x.Size)
                    .ThenBy(x => x.FullName)
                    .ToList();
            }

            if (result.Count > 0)
            {
                foreach (var fileEntry in result)
                {
                    Console.WriteLine(fileEntry);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        class FileEntry
        {
            public string Root { get; set; }
            public string FullName { get; set; }
            public string Extension { get; set; }
            public ulong Size { get; set; }

            public override string ToString()
            {
                return $"{FullName} - {Size} KB";
            }

            public override bool Equals(object obj)
            {
                if (obj == null || obj.GetType() != this.GetType())
                {
                    return false;
                }

                var other = (FileEntry)obj;

                return other.Root == Root
                       && other.FullName == FullName;
            }

            internal static FileEntry Parse(string fullPath)
            {
                var fileEntry = new FileEntry();

                var parts = fullPath.Split('\\');

                fileEntry.Root = parts[0];
                fileEntry.FullName = parts[parts.Length - 1].Split(';')[0];
                fileEntry.Extension = fileEntry.FullName.Split('.').Last();
                fileEntry.Size = ulong.Parse(parts[parts.Length - 1].Split(';')[1]);

                return fileEntry;
            }
        }
    }
}
