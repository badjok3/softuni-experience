namespace _07.Sum_Arrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main(string[] args)
        {
            var firstValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var length = Math.Max(firstValues.Length, secondValues.Length);
            var result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = firstValues[i % firstValues.Length] + secondValues[i % secondValues.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
