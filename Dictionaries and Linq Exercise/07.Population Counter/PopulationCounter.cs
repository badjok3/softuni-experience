namespace _07.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var countries = new Dictionary<string, Dictionary<string, long>>();
           

            while (line != "report")
            {
                var parameters = line.Split('|');
                var currentCity = parameters[0];
                var currentCountry = parameters[1];
                var currentPopulation = long.Parse(parameters[2]);

                if (!countries.ContainsKey(currentCountry))
                {
                    countries[currentCountry] = new Dictionary<string, long>();
                }

                if (!countries[currentCountry].ContainsKey(currentCity))
                {
                    countries[currentCountry][currentCity] = currentPopulation;
                }

                else
                {
                    countries[currentCountry][currentCity] += currentPopulation;
                }

                line = Console.ReadLine();
            }

            var population = new Dictionary<string, long>();
            foreach (var country in countries)
            {
                population[country.Key] = country.Value.Values.Sum();
            }

            foreach (var item in population.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var index in countries[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{index.Key}: {index.Value}");
                }
            }
        }
    }
}
