namespace _07.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class CountNumbers
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new SortedDictionary<int, int>();

            foreach (var digit in numbers)
            {
                if (!result.ContainsKey(digit))
                {
                    result[digit] = 0;
                }

                result[digit]++;
            }
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
