namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var allStars = new List<Participants>();
            var allSongs = new List<string>();

            foreach (var star in participants)
            {
                var currentParticipant = new Participants();
                currentParticipant.Name = star;
                currentParticipant.NumberOfAwards = 0;
                currentParticipant.Awards = new HashSet<string>();
                allStars.Add(currentParticipant);
            }

            foreach (var song in songs)
            {
                allSongs.Add(song.Trim());
            }

            while (true)
            {
                var currentPerformance = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (currentPerformance[0] == "dawn")
                {
                    break;
                }
                var currentParticipant = new Participants();
                var participant = currentPerformance[0];
                var song = currentPerformance[1].Trim();
                var award = currentPerformance[2].Trim();

                if (allStars.Any(x => x.Name == participant))
                {
                    currentParticipant = allStars.First(x => x.Name == participant);
                    if (!currentParticipant.Awards.Contains(award))
                    {
                        if (allSongs.Contains(song))
                        {
                            currentParticipant.Awards.Add(award);
                            currentParticipant.NumberOfAwards++;
                        }
                    }
                }
            }

            var hallOfFame = allStars.Where(x => x.NumberOfAwards > 0).ToList();
            if (hallOfFame.Count > 0)
            {
                foreach (var star in hallOfFame.OrderByDescending(x => x.NumberOfAwards).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{star.Name}: {star.NumberOfAwards} awards");
                    foreach (var award in star.Awards.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }

            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
