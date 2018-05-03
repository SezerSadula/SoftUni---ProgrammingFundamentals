using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadData();

            List<Group> groups = CreateGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {groups.Select(x => x.Town.Name).Distinct().Count()} towns:");

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(a => a.Email).ToList())}");
            }
        }

        private static List<Group> CreateGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.RegistationDate)
                    .ThenBy(s => s.Name)
                    .ThenBy(s => s.Email);

                var labCapacity = town.LabCapacity;
                while (students.Any())
                {
                    var group = new Group(town, students.Take(labCapacity).ToList());
                    groups.Add(group);
                    students = students.Skip(labCapacity);
                }
            }

            return groups;
        }

        private static List<Town> ReadData()
        {
            var towns = new List<Town>();

            var inputLine = Console.ReadLine();
            while (!"End".Equals(inputLine))
            {
                if (inputLine.Contains("=>"))
                {
                    var tokens = inputLine
                        .Split("=>".ToCharArray(),
                            StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray();

                    var townName = tokens[0];
                    var seats = int.Parse(tokens[1].Split()[0]);

                    Town town = new Town(townName, seats, new List<Student>());

                    towns.Add(town);
                }
                else
                {
                    var tokens = inputLine
                        .Split('|')
                        .Select(x => x.Trim())
                        .ToArray();

                    var name = tokens[0];
                    var email = tokens[1];
                    var registrationDate = DateTime.ParseExact(tokens[2], 
                        "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var student = new Student(name, email, registrationDate);

                    towns.Last().Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistationDate { get; set; }

        public Student(string name, string email, DateTime registationDate)
        {
            Name = name;
            Email = email;
            RegistationDate = registationDate;
        }
    }

    class Town
    {
        public string Name { get; set; }

        public int LabCapacity { get; set; }

        public List<Student> Students { get; set; }

        public Town(string name, int labCapacity, List<Student> students)
        {
            Name = name;
            LabCapacity = labCapacity;
            Students = students;
        }
    }

    class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }

        public Group(Town town, List<Student> students)
        {
            Town = town;
            Students = students;
        }
    }
}
