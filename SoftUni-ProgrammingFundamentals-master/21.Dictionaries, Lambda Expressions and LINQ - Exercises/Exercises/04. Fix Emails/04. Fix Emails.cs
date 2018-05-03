using System;
using System.Collections.Generic;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var mails = new Dictionary<string, string>();

            var name = Console.ReadLine();

            while (!name.Equals("stop"))
            {
                var email = Console.ReadLine();

                var domain = email.Substring(email.Length - 2).ToLower();

                if (!domain.Equals("us") && !domain.Equals("uk"))
                {
                    mails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var contact in mails)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}
