using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = persons / capacity;
            if (persons % capacity > 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
