namespace _07.Max_Sequence_Of_Increasing_Elements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            MaxSequence(numbers);
        }

        public static void MaxSequence(string numbers)
        {
            var parameters = numbers.Split(' ').Select(int.Parse).ToArray();
            var start = parameters[0];
            var length = 1;
            var bestLength = 0;
            var bestStart = parameters[0];
            for (int pos = 0; pos < parameters.Length - 1; pos++)
            {
                if (parameters[pos] < parameters[pos + 1])
                {
                    length++;
                }

                else
                {
                    start = parameters[pos + 1];
                    length = 1;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            var indexOfStart = Array.IndexOf(parameters, bestStart);
            int[] result = new int[bestLength];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = parameters[indexOfStart + i];
                Console.Write($"{result[i]} ");
            }
        }
    }
}
