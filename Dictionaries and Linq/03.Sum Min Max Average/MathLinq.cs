namespace _03.Math_Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MathLinq
    {
        public static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var result = new List<double>();
            for (int i = 0; i < numbers; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                result.Add(currentNumber);
            }

            Console.WriteLine($"Sum = {result.Sum()}");
            Console.WriteLine($"Min = {result.Min()}");
            Console.WriteLine($"Max = {result.Max()}");
            Console.WriteLine($"Average = {result.Average()}");
        }
    }
}
