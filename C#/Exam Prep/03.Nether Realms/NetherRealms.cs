namespace _03.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToArray();
            foreach (var demon in demons)
            {
                var damage = GetDamage(demon);
                var health = GetHealth(demon);

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }

        public static decimal GetDamage(string demon)
        {
            string pattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            var regex = new Regex(pattern);
            var numbers = regex.Matches(demon);

            decimal sum = 0;
            foreach (var match in numbers)
            {
                sum += decimal.Parse(match.ToString());
            }

            foreach (var symbol in demon.Where(x => x == '*' || x == '/'))
            {
                if (symbol == '*')
                {
                    sum *= 2;
                }

                else if (symbol == '/')
                {
                    sum /= 2;
                }
            }

            return sum;
        }

        public static int GetHealth(string demon)
        {
            var health = 0;
            foreach (var symbol in demon)
            {
                if (Regex.IsMatch(symbol.ToString(), @"[^\d\s.,*/+'-]"))
                {
                    health += symbol;
                }
            }

            return health;
        }
    }
}