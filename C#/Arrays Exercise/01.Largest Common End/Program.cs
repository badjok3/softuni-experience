namespace _01.Largest_Common_End
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split(' ');
            string[] secondString = Console.ReadLine().Split(' ');
            int maxCountLeft = ScanFromLeft(firstString, secondString);
            int maxCountRight = ScanFromRight(firstString, secondString);

            if (maxCountLeft == 0 && maxCountRight == 0)
            {
                Console.WriteLine(0);
            }

            else if (maxCountLeft >= maxCountRight)
            {
                Console.WriteLine(maxCountLeft);
            }

            else
            {
                Console.WriteLine(maxCountRight);
            }

        }

        public static int ScanFromLeft(string[] firstArray, string[] secondArray)
        {
            var counter = 0;
            var bestCounter = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }

                else
                {
                    counter = 0;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                }
            }

            return bestCounter;
        }

        public static int ScanFromRight(string[] firstArray, string[] secondArray)
        {
            var counter = 0;
            var bestCounter = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    counter++;
                }

                else
                {
                    counter = 0;
                }
                
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                }
            }
            return bestCounter;
        }
    }
}
