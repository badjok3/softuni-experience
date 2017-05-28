namespace _02.Sign_of_Integer_Number
{
    using System;

    public class SignOfInt
    {
        public static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }


        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
