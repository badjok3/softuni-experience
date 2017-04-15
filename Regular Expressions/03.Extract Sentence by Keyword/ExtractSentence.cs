namespace _03.Extract_Sentence_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;

   public class ExtractSentence
    {
        public static void Main()
        {
            var extractWord ="\\b" + Console.ReadLine() + "\\b";
            var text = Console.ReadLine().Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentence in text)
            {
                var match = Regex.Match(sentence, extractWord);

                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }

            }
        }
    }
}
