namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            SumNumbers(numbers);
        }

        public static void SumNumbers(string numbers)
        {
            var parameters = numbers.Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < parameters.Count; i++)
            {
                if (parameters[i - 1] == parameters[i])
                {
                    parameters[i - 1] += parameters[i];
                    parameters.RemoveAt(i);
                    i -= 2;
                    if (i < 0)
                    {
                        i = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", parameters));
        }
    }
}
