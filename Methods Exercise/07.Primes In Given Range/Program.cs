namespace _07.Primes_In_Given_Range
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrintPrimesInGivenRange
    {
        public static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ",GetPrimesInRange(startNumber, endNumber)));
        }
        
        public static bool IsPrime(int number)
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

            if (number < 2)
            {
                isPrime = false;
            }

            return isPrime;
        }

        public static List<int> GetPrimesInRange(int startNumber, int endNumber)
        {
            List<int> primesList = new List<int>();
            for (int i = startNumber; i < endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }
    }
}
