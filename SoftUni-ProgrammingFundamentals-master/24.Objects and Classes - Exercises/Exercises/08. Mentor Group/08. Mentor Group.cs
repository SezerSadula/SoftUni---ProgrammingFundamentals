using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsDict = new SortedDictionary<string, Student>();

            var input = Console.ReadLine();
            while (!"end of dates".Equals(input))
            {
                var tokens = input.Split().ToArray();

                var name = tokens[0];

                if (!studentsDict.ContainsKey(name))
                {
                    studentsDict[name] = new Student()
                    {
                        AttendanceDates = new List<DateTime>(),
                        Comments = new List<string>(),
                        Name = name
                    };
                }

                if (tokens.Length > 1)
                {
                    var dates = tokens[1].Split(',')
                            .Select(date => DateTime.ParseExact(
                                date, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                            .ToList();

                    studentsDict[name].AttendanceDates.AddRange(dates);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (!"end of comments".Equals(input))
            {
                var tokens = input.Split('-').ToArray();

                if (tokens.Length > 1)
                {
                    var name = tokens[0];
                    var comment = tokens[1];

                    if (studentsDict.ContainsKey(name))
                    {
                        studentsDict[name].Comments.Add(comment);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var student in studentsDict)
            {
                Console.Write(student.Value.GetInfo());
            }
        }
    }

    class Student
    {
        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> AttendanceDates { get; set; }

        public string GetInfo()
        {
            AttendanceDates.Sort();
            var comments = Comments
                .Select(comment => $"- {comment}\n")
                .ToList();
            var dates = AttendanceDates
                .Select(date => $"-- {date:dd/MM/yyyy}\n")
                .ToList();

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(Name);

            stringBuilder.AppendLine("Comments:");
            stringBuilder.Append(string.Join("", comments));

            stringBuilder.AppendLine("Dates attended:");
            stringBuilder.Append(string.Join("", dates));

            return stringBuilder.ToString();
        }
    }
}
