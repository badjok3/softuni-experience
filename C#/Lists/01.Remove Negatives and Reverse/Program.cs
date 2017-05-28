namespace _01.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            ReversePositives(numbers);
        }

        public static void ReversePositives(string numbers)
        {
            var parameters = numbers.Split(' ').Select(int.Parse).ToList();

            parameters.RemoveAll(x => x < 0);
            parameters.Reverse();
            if (parameters.Count > 0)
            {
                for (int i = 0; i < parameters.Count; i++)
                {
                    Console.Write($"{parameters[i]} ");
                }
            }
            
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
