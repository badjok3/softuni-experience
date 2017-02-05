namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class SquareNumbers
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }

            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
