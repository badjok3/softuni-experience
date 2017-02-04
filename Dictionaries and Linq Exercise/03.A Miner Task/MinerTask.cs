namespace _03.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            var resources = Console.ReadLine();
            var valuables = new List<string>();
            while (resources != "stop")
            {
                valuables.Add(resources);
                resources = Console.ReadLine();
            }

            var inventory = new Dictionary<string, int>();
            for (int i = 0; i < valuables.Count; i++)
            {
                if (i % 2 == 0)
                {
                    if (!inventory.ContainsKey(valuables[i]))
                    {
                        inventory[valuables[i]] = 0;
                    }
                }

                else
                {
                    inventory[valuables[i - 1]] += int.Parse(valuables[i]);
                }
            }

            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
