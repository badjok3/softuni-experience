using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var entryPoint = int.Parse(Console.ReadLine());
            var typeOfItem = Console.ReadLine();
            var priceRating = Console.ReadLine();

            var result = GetValues(items, priceRating, entryPoint, typeOfItem);

            Console.WriteLine(result);
        }

        public static string GetValues(long[] allItems, string priceRating, int entry, string type)
        {
            int entryPoint = (int)allItems[entry];

            var leftSide = allItems.Take(entry).ToList();
            var rightSide = allItems.Skip(entry).Take(allItems.Length - entryPoint - 1).ToList();
            switch (type)
            {
                case "expensive":
                    {
                        leftSide = leftSide.Where(x => x >= entryPoint).ToList();
                        rightSide = rightSide.Where(x => x >= entryPoint).ToList();
                        break;
                    }
                case "cheap":
                    {
                        leftSide = leftSide.Where(x => x < entryPoint).ToList();
                        rightSide = rightSide.Where(x => x < entryPoint).ToList();
                        break;
                    }
            }

            switch (priceRating)
            {
                case "negative":
                    {
                        var leftNegatives = leftSide.Where(x => x < 0).ToList();
                        var rightNegatives = rightSide.Where(x => x < 0).ToList();
                        if (leftNegatives.Sum() >= rightNegatives.Sum())
                        {
                            return "Left - " + leftNegatives.Sum();
                        }
                        else
                        {
                            return "Right - " + rightSide.Sum();
                        }
                    }

                case "positive":
                    {
                        var leftPositives = leftSide.Where(x => x > 0).ToList();
                        var rightPositives = rightSide.Where(x => x > 0).ToList();
                        if (leftPositives.Sum() >= rightPositives.Sum())
                        {
                            return "Left - " + leftPositives.Sum();
                        }

                        else
                        {
                            return "Right - " + rightPositives.Sum();
                        }
                    }

                case "all":
                    {
                        if (leftSide.Sum() >= rightSide.Sum())
                        {
                            return "Left - " + leftSide.Sum();
                        }

                        else
                        {
                            return "Right - " + rightSide.Sum();
                        }
                    }
            }

            return string.Empty;
        }
    }
}
