using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Population_Aggregation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var countries = new Dictionary<string, List<Cities>>();

            while (line != "stop")
            {
                var parameters = line.Split('\\');
                var firstPlace = GetPlace(parameters[0]);
                var secondPlace = GetPlace(parameters[1]);
                var population = long.Parse(parameters[2]);

                bool FirstPlaceisCountry = firstPlace.Any(c => Char.IsUpper(c));
                if (FirstPlaceisCountry)
                {
                    if (!countries.ContainsKey(firstPlace))
                    {
                        countries[firstPlace] = new List<Cities>();
                    }
                    var currentCity = new Cities
                    {
                        Name = secondPlace,
                        Population = population

                    };

                    countries[firstPlace].Add(currentCity);
                }
                else
                {
                    if (!countries.ContainsKey(secondPlace))
                    {
                        countries[secondPlace] = new List<Cities>();
                    }
                    var currentCity = new Cities
                    {
                        Name = firstPlace,
                        Population = population
                    };

                    countries[secondPlace].Add(currentCity);
                }

                line = Console.ReadLine();
            }

            foreach (var country in countries.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{country.Key} -> {country.Value.Count()}");
            }

            foreach (var city in countries.Values)
            {

            }
        }

        public static string GetPlace(string place)
        {
            var result = new StringBuilder();

            for (int i = 0; i < place.Length; i++)
            {
                if (Char.IsLetter(place[i]))
                {
                    result.Append(place[i]);
                }
            }

            return result.ToString();
        }
    }

    public class Cities
    {
        public string Name { get; set; }

        public long Population { get; set; }
    }
}
