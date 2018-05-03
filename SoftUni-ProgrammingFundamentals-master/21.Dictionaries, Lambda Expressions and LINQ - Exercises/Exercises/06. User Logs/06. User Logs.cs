using System;
using System.Collections.Generic;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new SortedDictionary<string, 
                Dictionary<string, int>>();

            var message = Console.ReadLine();
            while (!message.Equals("end"))
            {
                string userName = String.Empty;
                string ipAddress = String.Empty;
                UnpackMessage(message, ref userName, ref ipAddress);

                if (!log.ContainsKey(userName))
                {
                    log[userName] = new Dictionary<string, int>();
                }

                if (!log[userName].ContainsKey(ipAddress))
                {
                    log[userName][ipAddress] = 0;
                }

                log[userName][ipAddress]++;

                message = Console.ReadLine();
            }

            foreach (var user in log)
            {
                Console.WriteLine($"{user.Key}:");
                var ipAndCountList = new List<string>();
                foreach (var addressPair in user.Value)
                {
                    ipAndCountList.Add(
                        $"{addressPair.Key} => {addressPair.Value}");
                }

                Console.Write(string.Join(", ", ipAndCountList));
                Console.WriteLine(".");
            }
        }

        private static void UnpackMessage(string message, 
            ref string userName, ref string ipAddress)
        {
            var tokens = message
                .Split(new[] {' ', '='}, 
                StringSplitOptions.RemoveEmptyEntries);

            userName = tokens[5];
            ipAddress = tokens[1];
        }
    }
}
