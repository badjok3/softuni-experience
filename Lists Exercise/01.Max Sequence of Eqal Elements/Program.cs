namespace _01.Max_Sequence_of_Eqal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class MaxSequence
    {
       public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            GetMaxSequence(numbers); 
        }

        public static void GetMaxSequence(List<int> numbers)
        {
            var start = 0;
            var length = 1;
            var bestStart = 0;
            var bestLength = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    start = numbers[i - 1];
                    length++;
                }

                else
                {
                    length = 1;
                    start = i ;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write($"{bestStart} ");
            }
        }
    }
}
