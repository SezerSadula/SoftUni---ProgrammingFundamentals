using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var registartions = new Dictionary<string, string>();

            var operations = int.Parse(Console.ReadLine());

            for (int i = 0; i < operations; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                var user = input[1];

                if (input[0].Equals("register"))
                {
                    if (registartions.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registartions[user]}");
                        continue;
                    }

                    var licensePlateNumber = input[2];
                    if (!ValidateLicensePlateNum(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                        continue;
                    }

                    if (registartions.Values.Contains(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                        continue;
                    }

                    registartions[user] = licensePlateNumber;
                    Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                }
                else
                {
                    if (!registartions.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                        continue;
                    }

                    registartions.Remove(user);
                    Console.WriteLine($"user {user} unregistered successfully");
                }
            }

            foreach (var registartion in registartions)
            {
                Console.WriteLine($"{registartion.Key} => {registartion.Value}");
            }
        }

        private static bool ValidateLicensePlateNum(string licensePlateNumber)
        {
            if (licensePlateNumber.Length != 8)
            {
                return false;
            }

            var chars = licensePlateNumber.ToCharArray();
            for (int i = 0; i < 8; i++)
            {
                if (i < 2 || i > 5)
                {
                    if (!Char.IsLetter(chars[i]) || !Char.IsUpper(chars[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!Char.IsDigit(chars[i]))
                    {
                        return false;
                    }
                }
            }

            return true;

            /*   var aa = licensePlateNumber
                   .Skip(2)
                   .Take(4)
                   .All(c => char.IsDigit(c));
   
               var bb = licensePlateNumber
                   .ToCharArray()
                   .Take(2)
                   .Concat(licensePlateNumber
                       .ToCharArray()
                       .Skip(6)
                       .Take(2)
                       .ToArray())
                   .All(c => char.IsLetter(c) && char.IsUpper(c));
   
               return aa && bb;*/
        }
    }
}
