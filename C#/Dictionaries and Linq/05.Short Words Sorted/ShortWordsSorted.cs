namespace _05.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine();
            var result = words
                .ToLower()
                .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            var print = string.Join(", ", result);
            Console.WriteLine(print);
        }
    }
}
