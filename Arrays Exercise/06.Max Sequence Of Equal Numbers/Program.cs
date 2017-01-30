namespace _06.Max_Sequence_Of_Equal_Numbers
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualNumbers
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
            for (int pos = 1; pos <= parameters.Length - 1; pos++)
            {
                if (parameters[pos] == parameters[pos - 1])
                {
                    start = parameters[pos - 1];
                    length++;
                }

                else
                {
                    start = pos;
                    length = 1;
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
