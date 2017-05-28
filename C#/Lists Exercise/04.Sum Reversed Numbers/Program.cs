namespace _04.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            SumNumbers(numbers);
        }

        public static void SumNumbers(List<string> numbers)
        {
            long sumOfNumbers = 0;
            int number = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                char[] reverse = numbers[i].ToCharArray();
                Array.Reverse(reverse);
                var result = new string(reverse);
                number = int.Parse(result);

                sumOfNumbers += number;
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}
