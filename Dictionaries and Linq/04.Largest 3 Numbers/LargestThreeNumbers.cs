namespace _04.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            var result = numbers
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
