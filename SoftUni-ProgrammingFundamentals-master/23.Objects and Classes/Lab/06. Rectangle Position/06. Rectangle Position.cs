using System;
using System.Linq;

namespace _06.Rectangle_Position
{
    internal class Program
    {
        private static void Main()
        {
            var rectangleA = Rectangle.Parse(Console.ReadLine());
            var rectangleB = Rectangle.Parse(Console.ReadLine());

            Console.WriteLine(
                rectangleA.IsInside(rectangleB) 
                ? "Inside" 
                : "Not inside");
        }
    }

    internal class Rectangle
    {
        public int Left { get; }
        public int Top { get; }
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

        public static Rectangle Parse(string parameters)
        {
            var param = parameters
                .Split()
                .Select(int.Parse)
                .ToArray();

            return new Rectangle(param[0], param[1], param[2], param[3]);
        }

        public bool IsInside(Rectangle other)
        {
            return Left >= other.Left
                   && Left + Width <= other.Left + other.Width
                   && Top <= other.Top
                   && Top + Height <= other.Top + other.Height;
        }
    }
}
