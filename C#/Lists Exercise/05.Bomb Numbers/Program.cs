namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (true)
            {
                if (numbers.Contains(bomb[0]))
                {
                    int index = numbers.IndexOf(bomb[0]);

                    int indBeg = 0;
                    if ((index - bomb[1]) > 0)
                    {
                        indBeg = index - bomb[1];
                    }

                    int indEnd = (numbers.Count - 1);
                    if ((index + bomb[1]) < (numbers.Count - 1))
                    {
                        indEnd = index + bomb[1];
                    }

                    for (int i = indBeg; i <= indEnd; i++)
                    {
                        numbers.RemoveAt(indBeg);
                    }
                }

                if (!numbers.Contains(bomb[0]))
                    break;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}