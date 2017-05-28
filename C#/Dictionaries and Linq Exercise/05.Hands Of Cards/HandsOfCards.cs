namespace _05.Hands_Of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            var cardPowers = GetCardPower();
            var cardTypes = GetCardTypes();
            var people = new Dictionary<string, HashSet<int>>();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');
                var name = tokens[0];

                var cards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in cards)
                {
                    var cardPower = item.Substring(0, item.Length - 1);
                    var cardType = item.Substring(item.Length - 1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!people.ContainsKey(name))
                    {
                        people[name] = new HashSet<int>();
                    }

                    people[name].Add(sum);
                }

                line = Console.ReadLine();
            }

            foreach (var pair in people)
            {
                var name = pair.Key;
                var cardSum = pair.Value.Sum();

                Console.WriteLine($"{name}: {cardSum}");
            }
        }

        public static Dictionary<string, int> GetCardTypes()
        {
            var cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;
        }

        public static Dictionary<string, int> GetCardPower()
        {
            var result = new Dictionary<string, int>();
            for (int i = 2; i < 11; i++)
            {
                result[i.ToString()] = i;
            }

            result["J"] = 11;
            result["Q"] = 12;
            result["K"] = 13;
            result["A"] = 14;

            return result;
        }
    }
}
