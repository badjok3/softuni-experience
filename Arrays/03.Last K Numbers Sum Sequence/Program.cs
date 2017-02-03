namespace _03._Last_K_Numbers_Sum_Sequence
{
    using System;

    public class SumSequence
    {
        public static void Main(string[] args)
        {
            long arrayLength = long.Parse(Console.ReadLine());
            long numbersToSum = long.Parse(Console.ReadLine());
            var array = new long[arrayLength];

            array[0] = 1;
            for (int i = 1; i < arrayLength; i++)
            {
                array[i] = SumNums(array, i - numbersToSum, i - 1);
            }

            Console.WriteLine(string.Join(" ", array));
        }

        public static long SumNums(long[] arr, long startIndex, long endIndex)
        {
            long sum = 0;

            for (long i = startIndex; i <= endIndex; i++)
            {
                if (i>=0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

    }
}
