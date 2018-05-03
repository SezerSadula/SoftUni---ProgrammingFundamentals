using System;
using System.Collections.Generic;

namespace _01.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            var line = Console.ReadLine();

            while (!"End".Equals(line))
            {
                var tokens = line.Split();

                persons.Add(
                    new Person(tokens[0], tokens[1], int.Parse(tokens[2])));

                line = Console.ReadLine();
            }

            persons.Sort();

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }
}
