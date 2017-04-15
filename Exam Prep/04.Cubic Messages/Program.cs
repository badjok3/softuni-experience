using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();

            while (message != "Over!")
            {
                int messageLength = int.Parse(Console.ReadLine());

                var pattern = @"(^\d+)([A-Za-z]+)([^A-Za-z]*$)";
                var match = Regex.Match(message, pattern);

                var result = new StringBuilder();
                if (match.Success && match.Groups[2].Length == messageLength)
                {
                    var indexes = match.Value.Where(Char.IsDigit).ToArray();
                    var text = match.Groups[2].Value;

                    for (int i = 0; i < indexes.Count(); i++)
                    {
                        var currentIndex = int.Parse(indexes[i].ToString());
                        if (currentIndex >= 0 && currentIndex < text.Length)
                        {
                            result.Append(text[currentIndex]);
                        }
                        else if (currentIndex >= text.Length)
                        {
                            result.Append(" ");
                        }
                    }

                    Console.WriteLine($"{text} == {result.ToString()}");
                }
                message = Console.ReadLine();
            }
        }
    }
}
