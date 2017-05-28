namespace _13.Factorial
{
    using System;
    using System.Numerics;

   public class GetFactorial
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(number);
            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
