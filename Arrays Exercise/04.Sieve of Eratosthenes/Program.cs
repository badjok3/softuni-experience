namespace _04.Sieve_of_Eratosthenes
{
    using System;

    public class Sieve
    {
        public static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] primesList = new int[arraySize + 1];
            primesList[0] = 0;
            primesList[1] = 1;
            bool[] isPrime = MakeSieve(arraySize);
            string result = string.Empty;

            for (int i = 2; i < primesList.Length; i++)
            {
                if (isPrime[i])
                {
                    primesList[i] = i;
                    result = string.Join(" ", primesList[i]);
                    Console.WriteLine(result);
                }
            }
        }
        
        public static bool[] MakeSieve(int max)
        {
            // Make an array indicating whether numbers are prime.
            bool[] isPrime = new bool[max + 1];
            for (int i = 2; i <= max; i++) isPrime[i] = true;

            // Cross out multiples.
            for (int i = 2; i <= max; i++)
            {
                // See if i is prime.
                if (isPrime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        isPrime[j] = false;
                }
            }

            return isPrime;
        }


    }
}
