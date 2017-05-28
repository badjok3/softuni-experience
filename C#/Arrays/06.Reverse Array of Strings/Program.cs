namespace _06.Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

   public class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            string[] arrayOfValues = strings.Split(' ');
            Array.Reverse(arrayOfValues);

            for (int i = 0; i < arrayOfValues.Length; i++)
            {
                Console.Write($"{arrayOfValues[i]} ");
            }
        }
    }
}

