namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            var randomNumberGenerator = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = randomNumberGenerator.Next(0, words.Length);

                var tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currentWord;
            }

            foreach (var item in words)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
