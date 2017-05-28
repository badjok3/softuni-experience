namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            AppendList(numbers);
        }

        public static void AppendList(string numbers)
        {
            var parameters = numbers.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            parameters.Reverse();
            var resultList = new List<int>();

            for (int i = 0; i < parameters.Count; i++)
            {
                var num = parameters[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < num.Length; j++)
                {
                    resultList.Add(int.Parse(num[j]));
                }
            }
            var result = string.Join(" ", resultList);
            Console.Write(result);

        }
    }
}
