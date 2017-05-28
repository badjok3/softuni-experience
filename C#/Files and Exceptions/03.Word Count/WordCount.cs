namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class WordCount
    {
        static void Main()
        {
            var text = File.ReadAllText("text.txt").ToLower().Split(' ');
            var checkWords = File.ReadAllText("words.txt").Split(' ');
            var count = 1;
            var result = new Dictionary<string, int>();

            for (int i = 0; i < checkWords.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (checkWords[i] == text[j])
                    {
                        count++;
                    }
                }

                result[checkWords[i]] = count;
                count = 1;
            }

            var output = result.OrderByDescending(x => x.Value);

            foreach (var item in output)
            {
                File.AppendAllText("output.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
                Console.WriteLine();
            }

        }
    }
}
