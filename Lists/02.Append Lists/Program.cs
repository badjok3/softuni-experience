namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            AppendList(numbers);
        }

        public static void AppendList(string numbers)
        {
            var parameters = numbers.Split('|').ToList();
            parameters.Reverse();
            var resultList = new List<int>();

            for (int i = 0; i < parameters.Count; i++)
            {
                string currentString = parameters[i];
                for (int j = 0; j < currentString.Length; j++)
                {
                    char values = currentString[j];

                    if (Char.IsDigit(values))
                    {
                        resultList.Add(values - '0');
                    }
                }
            }
            var result = string.Join(" ", resultList);
            Console.Write(result);

        }
    }
}
