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
            var people = new Dictionary<string, int>();

            while (line!="JOKER")
            {
                var tokens = line.Split(':');
                if (people.ContainsKey(tokens[0]))
                {
                    people[tokens[0]] = 0;
                }
                var cards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                line = Console.ReadLine();
            }
        }
    }
}
