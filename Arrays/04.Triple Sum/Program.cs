namespace _04.Triple_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool hasSum = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    var sum = numbers[a] + numbers[b];

                    if (numbers.Contains(sum))
                    {
                        hasSum = true;
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                    }
                }
            }

            if (!hasSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
