namespace _08.Multiply_Evens_By_Odds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfEvensAndOdds(num);

            Console.WriteLine(result);         
        }

        public static int GetMultipleOfEvensAndOdds(int num)
        {
            return Math.Abs(GetSumOfEvenDigits(num)
                  * GetSumOfOddDigits(num));
        }

        public static int GetSumOfOddDigits(int num)
        {
            var result = 0;

            foreach (var symbol in num.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 1)
                {
                    result += digit;
                }
            }

            return result;
        }

        public static int GetSumOfEvenDigits(int num)
        {
            var result = 0;

            foreach (var symbol in num.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
