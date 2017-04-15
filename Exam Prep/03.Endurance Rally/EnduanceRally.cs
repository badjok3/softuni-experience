namespace _03.Endurance_Rally
{
    using System;
    using System.Linq;

    public class EnduanceRally
    {
        public static void Main()
        {
            var racers = Console.ReadLine().Split(' ');
            var checkpoints = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var indexOfCheckpoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double fuel = 0;

            for (int i = 0; i < racers.Length; i++)
            {
                var currentRacer = racers[i].ToCharArray();
                var counter = 0;
                fuel = currentRacer[0];

                for (int j = 0; j < checkpoints.Count; j++)
                {
                    if (indexOfCheckpoint.Any(x => x == j))
                    {
                        fuel += checkpoints[j];
                    }

                    else
                    {
                        fuel -= checkpoints[j];
                    }

                    if (fuel <= 0)
                    {
                        fuel = 0;
                        break;
                    }

                    counter++;
                }

                if (counter > checkpoints.Count - 1)
                {
                    Console.WriteLine($"{racers[i]} - fuel left {fuel:f2}");
                }

                else
                {
                    Console.WriteLine($"{racers[i]} - reached {counter}");
                }

                counter = 0;
                fuel = 0;
            }
        }
    }
}
