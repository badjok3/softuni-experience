namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            SumNumbers(numbers);
        }

        public static void SumNumbers(string numbers)
        {
            var parameters = numbers.Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

          
                for (int i = 0; i < parameters.Count - 1; i++)
                {
                    if (parameters[i] == parameters[i + 1])
                    {
                        parameters[i] += parameters[i + 1];
                        parameters.Remove(parameters[i + 1]);
                    }
                }
            
 
        }
    }
}
