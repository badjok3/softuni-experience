namespace _03.Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            var result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if (text.Contains(words[i]))
                {
                   result = text.Replace(words[i], new string('*', words[i].Length));
                }

                text = result;
            }

            Console.WriteLine(text);
        }
    }
}
