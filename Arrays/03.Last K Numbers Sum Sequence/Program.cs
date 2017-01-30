namespace _03._Last_K_Numbers_Sum_Sequence
{
    using System;

    public class SumSequence
    {
        public static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int numbersToSum = int.Parse(Console.ReadLine());
            var array = new int[arrayLength];

            array[0] = 1;
            for (int i = arrayLength-numbersToSum; i <= arrayLength - 1; i++)
            {

                for (int j = 1; j < arrayLength - 1; j++)
                {
                    array[i] = i;
                    array[j] = array[i];
                }

            }
        }

    }
}
