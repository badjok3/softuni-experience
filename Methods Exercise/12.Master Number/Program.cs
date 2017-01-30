namespace _12.Master_Number
{
    using System;

    public class MasterNumber
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (isSymetric(i) && DivisibleBySeven(i) && hasEvenDigit(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static bool isSymetric(int number)
        {
            int currentNumber = number;
            int result = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                result = result * 10 + currentDigit;
                number /= 10;
            }

            if (currentNumber == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DivisibleBySeven(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int digit = number % 10;
                result += digit;
                number /= 10;
            }

            if (result % 7 == 0)
            {
                return true;
            }

            {
                return false;
            }
        }

        public static bool hasEvenDigit(int number)
        {
            while (number > 0)
            {
                int result = number % 10;
                if (result % 2 == 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
