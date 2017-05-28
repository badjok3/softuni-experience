namespace _02.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"([\w-.]+@[A-Za-z][\w-.]+[A-Za-z]+)(\.[A-Za-z]+)+";
            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (!(match.ToString().StartsWith("-") ||
                    match.ToString().StartsWith(".") ||
                    match.ToString().StartsWith("_") ||
                    match.ToString().EndsWith("_") ||
                    match.ToString().EndsWith(".") ||
                    match.ToString().EndsWith("-")))
                {

                    Console.WriteLine(match);
                }
            }
        }
    }
}
