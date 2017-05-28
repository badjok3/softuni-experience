namespace _04.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var usernames = Console.ReadLine().Split(new[] {' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();
            var allMatches = new List<string>();
            var pattern = @"\b([A-Za-z]\w{2,24})\b";
            var largestSum = 0;
            for (int i = 0; i < usernames.Length; i++)
            {
                var match = Regex.Match(usernames[i], pattern);
                if (match.Success)
                {
                    allMatches.Add(match.ToString());
                }
            }

            for (int i = 0; i < allMatches.Count - 1; i++)
            {
                var currentSum = allMatches[i].Length + allMatches[i + 1].Length;
                if (currentSum > largestSum)
                {
                    largestSum = currentSum;
                }
                result[string.Join(" ", allMatches[i], allMatches[i + 1])] = currentSum;
            }

            var output = result.OrderByDescending(x => x.Value);

            foreach (var item in output)
            {
                var parameters = item.Key.Split(' ');
                foreach (var username in parameters)
                {
                    Console.WriteLine(username);
                }

                break;
            }
        }
    }
}
