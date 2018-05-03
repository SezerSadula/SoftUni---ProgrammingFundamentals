using System;

namespace _08.Personal_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                try
                {
                    if (number < 0)
                    {
                        throw new MyException("My first exception is awesome!!!");
                    }

                    Console.WriteLine(number);
                }
                catch (MyException me)
                {
                    Console.WriteLine(me.Message);
                    return;
                }

            }
        }
    }

    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
