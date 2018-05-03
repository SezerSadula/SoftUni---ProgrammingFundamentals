using System;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            int charsInMessage = int.Parse(Console.ReadLine());

            for (int i = 0; i < charsInMessage; i++)
            {
                message += DecodeChar(Console.ReadLine());
            }

            Console.WriteLine(message);
        }

        private static char DecodeChar(string code)
        {
            if (code == "0")
            {
                return ' ';
            }

            int mainDigit = code[0] - '0';

            int offset = (mainDigit - 2) * 3;

            if (mainDigit > 7)
            {
                offset++;
            }

            int index = (int)'a' + offset + code.Length - 1;

            return  (char)index;
        }
    }
}
