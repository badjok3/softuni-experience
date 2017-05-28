namespace _01.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).OrderBy(x => x);
            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
