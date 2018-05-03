using System;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = ulong.Parse(Console.ReadLine());

            for (ulong num = 1; num <= range; num++)
            {
                if (IsMasterNumber(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        private static bool IsMasterNumber(ulong num)
        {
            byte size = (byte)num.ToString().Length;
            byte [] digits = GetDigitsArray(num, size);

            return IsSymmetric(digits) 
                && SumIsDivisibleBy7(digits) 
                && HasEvenDigit(digits);
        }

        private static byte [] GetDigitsArray(ulong num, byte size)
        {
            byte [] digits = new byte[size];

            byte index = 0;

            while (num > 0)
            {
                digits[index++] = (byte)(num % 10);
                num = num / 10;
            }

            return digits;
        }

        private static bool HasEvenDigit(byte[] digits)
        {
            foreach (var digit in digits)
            {
                if (digit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool SumIsDivisibleBy7(byte[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            return sum % 7 == 0;
        }

        private static bool IsSymmetric(byte[] digits)
        {
            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
