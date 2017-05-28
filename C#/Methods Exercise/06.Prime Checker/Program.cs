namespace _06.Prime_Checker
{
    using System;

    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool result = IsPrime(number);
            Console.WriteLine(result);
        }

        public static bool IsPrime(long number)
        {
            bool isPrime = true;
            for (int primeChecker = 2; primeChecker <= Math.Sqrt(number); primeChecker++)
            {
                if (number % primeChecker == 0)
                {
                    isPrime = false;
                    break;
                }
            }

                if (number<2)
                {
                    isPrime = false;
                }
            
            return isPrime;
        }
    }
}
