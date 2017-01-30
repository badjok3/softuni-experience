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
            var start = 0;
            var length = 1;
            var bestLength = 0;
            var bestStart = 0;
            for (int pos = 0; pos < parameters.Length - 1; pos++)
            {
                if (parameters[pos] < parameters[pos + 1])
                {
                    length++;

                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }

                else
                {
                    start = pos + 1;
                    length = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write($"{parameters[i]} ");
            }
        }
    }
}