namespace _03.Fold_and_Sum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] leftFold = new int[numbers.Length / 4];
            int[] rightFold = new int[numbers.Length / 4];
            int[] result = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                leftFold[i] = numbers[numbers.Length / 4 - i - 1];
                rightFold[i] = numbers[numbers.Length - i - 1];
            }

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                result[i] = leftFold[i] + numbers[numbers.Length / 4 + i];
                result[numbers.Length / 4 + i] = numbers[numbers.Length / 2 + i] + rightFold[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
