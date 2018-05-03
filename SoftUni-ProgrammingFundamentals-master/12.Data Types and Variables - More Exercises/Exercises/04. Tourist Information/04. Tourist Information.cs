using System;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            string valueAsString = Console.ReadLine();
            double valueToConvert = double.Parse(valueAsString);

            string metricUnit = "";
            double valueMultiplier = 0d;

            switch (imperialUnit)
            {
                case "miles":
                    metricUnit = "kilometers";
                    valueMultiplier = 1.6d;
                    break;
                case "inches":
                    metricUnit = "centimeters";
                    valueMultiplier = 2.54d;
                    break;
                case "feet":
                    metricUnit = "centimeters";
                    valueMultiplier = 30d;
                    break;
                case "yards":
                    metricUnit = "meters";
                    valueMultiplier = 0.91d;
                    break;
                case "gallons":
                    metricUnit = "liters";
                    valueMultiplier = 3.8d;
                    break;
                default:
                    break;
            }

            double convertedValue = valueToConvert * valueMultiplier;

            Console.WriteLine($"{valueAsString} {imperialUnit} = {convertedValue:F2} {metricUnit}");
        }
    }
}
