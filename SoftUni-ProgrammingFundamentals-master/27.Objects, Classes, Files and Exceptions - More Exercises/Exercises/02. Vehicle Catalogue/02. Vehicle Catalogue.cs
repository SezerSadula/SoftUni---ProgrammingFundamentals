using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Vehicle_Catalogue
{
    enum VehicleType
    {
        Truck = 0,
        Car = 1
    };

    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new Dictionary<string, Vehicle>();

            var line = Console.ReadLine();

            while (!"End".Equals(line))
            {
                var tokens = line.Split();

                var type = GetType(tokens[0].ToLower());
                var model = tokens[1];
                var color = tokens[2];
                var horsePower = int.Parse(tokens[3]);

                vehicles.Add(model, new Vehicle(type, model, color, horsePower));

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (!"Close the Catalogue".Equals(line))
            {
                Console.WriteLine(vehicles[line]);

                line = Console.ReadLine();
            }

            var carsAverageHorsepower = GetAverageHorsePowerForType(vehicles, VehicleType.Car);
            var trucksAverageHorsepower = GetAverageHorsePowerForType(vehicles, VehicleType.Truck);

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:F2}.");
        }

        private static double GetAverageHorsePowerForType(
            Dictionary<string, Vehicle> vehicles, VehicleType type)
        {
            var horsepowersList = vehicles
                .Where(vehicle => vehicle.Value.Type == type)
                .Select(vehicle => vehicle.Value.Horsepower)
                .ToList();

            var averageHorsepower = 0d;

            if (horsepowersList.Count > 0)
            {
                averageHorsepower = horsepowersList.Average();
            }

            return averageHorsepower;
        }

        private static VehicleType GetType(string type)
        {
            return "truck".Equals(type) ?
                VehicleType.Truck : VehicleType.Car;
        }
    }

    class Vehicle
    {
        public VehicleType Type { get; }

        public string Model { get; }

        public string Color { get; }

        public int Horsepower { get; }

        public Vehicle(VehicleType type, string model,
            string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.Append($"Horsepower: {Horsepower}");

            return sb.ToString();
        }
    }
}
