namespace _01.Replace_a_tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = "[URL href=$1]$2[/URL]";
                var result = Regex.Replace(text, pattern, replace);

                Console.WriteLine(result);
                text = Console.ReadLine();
            }
        }
    }
}
