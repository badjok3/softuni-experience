namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new HashSet<string>();

            var reversed = string.Empty;
            for (int i = line.Length - 1; i > -1; i--)
            {
                var word = line[i].ToCharArray();
                Array.Reverse(word);
                string tempWord = new string(word);
                if (line[i] == tempWord)
                {
                    palindromes.Add(line[i]);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
