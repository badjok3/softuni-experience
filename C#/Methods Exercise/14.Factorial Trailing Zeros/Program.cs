namespace _14.Factorial_Trailing_Zeros
{
    using System;
    using System.Numerics;

   public class TrailingZeros
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(number);
            int result = FindTrailingZeros(factorial);

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

        public static int FindTrailingZeros(BigInteger factorial)
        {
            int counter = 0;
            BigInteger result = factorial;
            while(result%10==0)
            {
                result /= 10;
                counter++;
            }
       

            return counter;
        }
    }
}
