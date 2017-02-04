namespace _06.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;
            var firstRow = numbers.Take(k)
                .Reverse()
                .ToArray();
            var secondRow = numbers.Reverse()
                .Take(k)
                .ToArray();

            var lowerRow = numbers.Skip(k)
                .Take(2 * k)
                .ToArray();
            var upperRow = firstRow.Concat(secondRow)
                .ToArray();
            var result = new int[2 * k];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
