using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab13SplitByWordCasing
{
    public class Lab13SplitByWordCasing
    {
        public static void Main()
        {
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();

            foreach (var w in input)
            {
                var type = GetWordType(w);

                if (type == WordType.UpperCase)
                {
                    upperCaseList.Add(w);
                }

                else if (type == WordType.LowerCase)
                {
                    lowerCaseList.Add(w);
                }

                else if (type == WordType.MixedCase)
                {
                    mixedCaseList.Add(w);
                }
            }

            Console.WriteLine("Lower-case: " + String.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCaseList));

        }

        enum WordType { UpperCase, MixedCase, LowerCase };

        private static WordType GetWordType(string word)
        {
            var lowerLetters = 0;
            var upperLetters = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l))
                {
                    upperLetters++;
                }

                else if (char.IsLower(l))
                {
                    lowerLetters++;
                }
            }

            if (upperLetters == word.Length)
            {
                return WordType.UpperCase;
            }

            if (lowerLetters == word.Length)
            {
                return WordType.LowerCase;
            }

            return WordType.MixedCase;

        }

    }
}