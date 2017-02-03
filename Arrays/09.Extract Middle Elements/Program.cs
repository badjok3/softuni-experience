namespace _09.Extract_Middle_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractMiddleElemets
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("{ ");
            if (numbers.Length == 1)
            {
                Console.WriteLine($"{numbers[0]}");
            }

            else if (numbers.Length % 2 != 0)
            {
                Console.Write($"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]}");
            }

            else
            {
                Console.Write($"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}");
            }

            Console.Write(" }");
        }
    }
}
