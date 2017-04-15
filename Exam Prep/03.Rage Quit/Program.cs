using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);

            var input = Console.ReadLine().ToUpper();
            var matches = regex.Matches(input);
            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                var line = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(line);
                }
            }
            
            Console.WriteLine($"Unique symbols used: {result.ToString().ToCharArray().Distinct().Count()}");
            Console.WriteLine(result.ToString());
        }
    }
}
