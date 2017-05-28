namespace _02.Reverse_Array_of_Integers
{
    using System;

    public class ReverseArrayOfInt
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var numbersArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbersArray[i] = currentNumber;
            }

            Array.Reverse(numbersArray);

            foreach (var num in numbersArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
