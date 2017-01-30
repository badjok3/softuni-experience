namespace _07.Sum_Arrays
{
    using System;

   public class SumArrays
    {
       public static void Main(string[] args)
        {
            var firstValues = Console.ReadLine();
            var secondValues = Console.ReadLine();

            var firstArr = firstValues.Split(' ');
            var secondArr = secondValues.Split(' ');
            var intArray = new int[firstArr.Length];
            var secondArray = new int[secondArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                intArray[i] = int.Parse(firstArr[i]);
            }


        }


    }
}
