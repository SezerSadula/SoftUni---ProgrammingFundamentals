using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().Trim().ToLower();

            double result = 0d;
            switch (parameter)
            {
                case "face":
                    result = CalculteCubeFaceDigonal(cubeSide);
                    break;
                case "space":
                    result = CalculteCubeSpaceDiagonal(cubeSide);
                    break;
                case "volume":
                    result = CalculteCubeVolume(cubeSide);
                    break;
                case "area":
                    result = CalculteCubeArea(cubeSide);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{result:F2}");
        }

        private static double CalculteCubeArea(double cubeSide)
        {
            return 6d * cubeSide * cubeSide;
        }

        private static double CalculteCubeVolume(double cubeSide)
        {
            return Math.Pow(cubeSide, 3d);
        }

        static double CalculteCubeSpaceDiagonal(double cubeSide)
        {
            return Math.Sqrt(3d * cubeSide * cubeSide);
        }

        static double CalculteCubeFaceDigonal(double cubeSide)
        {
            return Math.Sqrt(2d * cubeSide * cubeSide);
        }
    }
}
