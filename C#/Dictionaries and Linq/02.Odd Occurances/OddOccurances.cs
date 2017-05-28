namespace _02.Odd_Occurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurances
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }

                wordCount[word]++;
            }

            var result = new List<string>();
            foreach (var word in wordCount)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            var print = string.Join(", ", result);
            Console.WriteLine(print);
        }
    }
}
