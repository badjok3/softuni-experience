namespace _08.Multiply_Evens_By_Odds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main(string[] args)
        {
        }

        public static int GetMultipleOfEvensAndOdds(int num)
        {
            int sumEvens = GetSumOfEvenDigits(num);
            int sumOdds = GetSumOfOddDigits(num);

            return sumEvens * sumOdds;
        }

        public static int GetSumOfEvenDigits(int num)
        {

        }
    }
}
