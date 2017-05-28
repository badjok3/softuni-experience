using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KuraMiQnko
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var line = Console.ReadLine();
            var teams = new List<Teams>();

            while (line != "final")
            {
                var pattern = $@"[{key}]([A-Za-z]+)[{key}]";
                var matches = Regex.Matches(line, pattern);
                var firstTeam = GetTeam(matches[0].ToString()).Trim(key[0]);
                var secondTeam = GetTeam(matches[1].ToString()).Trim(key[0]);

                var scorePattern = @"(\d:\d)";
                var score = Regex.Match(line, scorePattern);
                var totalScore = score.ToString().Split(':');
                var firstTeamScore = int.Parse(totalScore[0]);
                var secondTeamScore = int.Parse(totalScore[1]);

                var teamOne = new Teams();
                teamOne.Name = firstTeam;
                var teamTwo = new Teams();
                teamTwo.Name = secondTeam;

                if (teams.Any(x => x.Name == teamOne.Name))
                {
                    teamOne = teams.First(x => x.Name == teamOne.Name);
                }

                if (teams.Any(x => x.Name == teamTwo.Name))
                {
                    teamTwo = teams.First(x => x.Name == teamTwo.Name);
                }
                if (firstTeamScore > secondTeamScore)
                {
                    teamOne.Points += 3;
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    teamOne.Points += 1;
                    teamTwo.Points += 1;
                }
                else
                {
                    teamTwo.Points += 3;
                }

                teamOne.Goals += firstTeamScore;
                teamTwo.Goals += secondTeamScore;

                teams.Add(teamOne);
                teams.Add(teamTwo);

                line = Console.ReadLine();
            }

            var result = teams.OrderByDescending(x => x.Points);
            var positionCounter = 1;
            Console.WriteLine("League standings:");
            foreach (var team in result)
            {
                Console.WriteLine($"{positionCounter}. {team.Name} {team.Points}");
                positionCounter++;
            }

            var printCounter = 0;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teams.OrderByDescending(x => x.Goals))
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
                printCounter++;
                if (printCounter == 3)
                {
                    break;
                }
            }
        }
        public static string GetTeam(string match)
        {
            var team = string.Empty;

            for (int i = match.Length - 1; i > -1; i--)
            {
                team += match[i];
            }

            return team.ToUpper();
        }
    }

    class Teams
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public int Goals { get; set; }
    }
}
