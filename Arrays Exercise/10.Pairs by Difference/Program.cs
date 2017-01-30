namespace _10.Pairs_by_Difference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            int difference = int.Parse(Console.ReadLine());
            GetPairs(sequence, difference);
        }

        public static void GetPairs(string sequence, int difference)
        {
            int[] numbers = sequence.Split(' ').Select(int.Parse).ToArray();
            var counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {

                if (Math.Abs(numbers[i] - numbers[j]) == difference && i<j)
                {
                    counter++;
                }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
