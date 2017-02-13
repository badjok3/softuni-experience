namespace _02.Count_Substring_Occurances
{
    using System;

    public class CountSubstringOccurances
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var count = 0;
            int index = text.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(substring, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
