using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsList = new List<Student>();
            var studentsToRead = int.Parse(Console.ReadLine());

            while (studentsToRead-- > 0)
            {
                var studentData = Console.ReadLine()
                    .Split();

                var name = studentData[0];

                var grades = studentData
                    .Where((x, index) => index > 0)
                    .Select(double.Parse)
                    .ToList();

                studentsList.Add(new Student(name, grades));
            }

            studentsList = studentsList
                .Where(student => student.AverageGrade>= 5d)
                .ToList();

            studentsList.Sort();

            foreach (var student in studentsList)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }

        class Student : IComparable<Student>
        {
            public string Name { get; set; }
            private List<double> Grades;

            public Student(string name, List<double> grades)
            {
                Name = name;
                Grades = grades;
            }

            public double AverageGrade => Grades.Average();

            public int CompareTo(Student other)
            {
                var cmp = string.Compare(Name, other.Name, StringComparison.Ordinal);
                cmp = Name.CompareTo(other.Name);
                if (cmp != 0)
                {
                    return cmp;
                }

                return -AverageGrade.CompareTo(other.AverageGrade);
            }
        }
    }
}
