namespace _08.Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
