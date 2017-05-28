namespace _05.Fibonacci_Numbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long result = GetFibonacciNumber(number);

            Console.WriteLine(result);
        }

        public static long GetFibonacciNumber(long number)
        {
            long result = 0;
            long firstFibonacci = 1;
            long secondFibonacci = 1;

            if (number < 2)
            {
                return 1;
            }

            for (int i = 1; i < number; i++)
            {
                result = firstFibonacci + secondFibonacci;
                secondFibonacci = firstFibonacci;
                firstFibonacci = result;
            }

            return result;
        }
    }
}
