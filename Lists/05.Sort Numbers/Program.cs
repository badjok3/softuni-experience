namespace _05.Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
       public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            SortNums(numbers);
        }

        public static void SortNums(string numbers)
        {
            var parameters = numbers.Split(' ').Select(long.Parse).ToList();
            parameters.Sort();
            Console.Write(parameters[0]);
            for (int i = 1; i < parameters.Count; i++)
            {
                Console.Write($" <= {parameters[i]}");
            }
        }
    }
}
