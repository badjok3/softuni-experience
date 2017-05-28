namespace _09.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            bool sum = true;
            var materialsInfo = new Dictionary<string, int>();
            materialsInfo["shards"] = 0;
            materialsInfo["fragments"] = 0;
            materialsInfo["motes"] = 0;
            string winner = string.Empty;

            while (sum)
            {
                string[] items = input.ToLower().Split(' ');
                int quantity = 0;
                string material = string.Empty;

                for (int i = 1; i <= items.Length; i += 2)
                {
                    material = items[i].ToLower();

                    quantity = int.Parse(items[i - 1]);

                    if (!materialsInfo.ContainsKey(material))
                    {
                        materialsInfo.Add(material, 0);
                    }

                    materialsInfo[material] += quantity;

                    if (materialsInfo[material] >= 250)
                    {
                        winner = material;
                        materialsInfo[material] -= 250;
                        sum = false;
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            if (winner == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (winner == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (winner == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            var sortedKeyMaterials = materialsInfo.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var sortedJunk = materialsInfo.Skip(3).OrderBy(x => x.Key);

            foreach (var item in sortedKeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in sortedJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}