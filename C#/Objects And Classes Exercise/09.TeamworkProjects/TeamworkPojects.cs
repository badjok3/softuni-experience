namespace _09.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamworkPojects
    {
        public static void Main()
        {
            var numberOfTeams = int.Parse(Console.ReadLine());
            var allTeams = new List<Team>();
            var createTeams = string.Empty;

            //Create teams and add valid ones to allTeams
            for (int i = 0; i < numberOfTeams; i++)
            {
                createTeams = Console.ReadLine();
                var parameters = createTeams.Split('-');
                var currentTeam = new Team
                {
                    Name = parameters[1],
                    Creator = parameters[0]
                };

                //Check if team has already been created
                if (!allTeams.Any(t => t.Name == currentTeam.Name))
                {
                    currentTeam.Members = new List<string>();
                    Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
                    allTeams.Add(currentTeam);
                }

                //Check if user has already created a team
                else if (allTeams.Any(t => t.Creator == currentTeam.Creator))
                {
                    Console.WriteLine($"{currentTeam.Creator} cannot create another team!");
                }

                else
                {
                    Console.WriteLine($"Team {currentTeam.Name} was already created!");
                }
            }

            var joinTeams = Console.ReadLine();

            //Add members to valid teams
            while (joinTeams != "end of assignment")
            {
                var parameters = joinTeams.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var currentUser = parameters[0];
                var currentTeam = new Team();
                currentTeam.Name = parameters[1];
                currentTeam.Members = new List<string>();

                //Check if currentTeam is valid
                if (allTeams.Any(t => t.Name == currentTeam.Name))
                {
                    currentTeam = allTeams.First(x => x.Name == currentTeam.Name);

                    //Check if currentUser is already signed in another team or has created one
                    if ((!allTeams.Any(m => m.Members.Contains(currentUser)) && (currentTeam.Creator != currentUser)))
                    {
                        currentTeam.Members.Add(currentUser);
                    }

                    else
                    {
                        Console.WriteLine($"Member {currentUser} cannot join team {currentTeam.Name}!");
                    }
                }

                else
                {
                    Console.WriteLine($"Team {currentTeam.Name} does not exist!");
                }

                joinTeams = Console.ReadLine();
            }

            //Add teams with members to a seperate list
            var teamsWithMembers = allTeams.OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .Where(x => x.Members.Count() > 0)
                .ToList();

            //Print teams with members
            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            //Add teams without members to a seperate list
            var disbandTeams = allTeams.OrderBy(x => x.Name)
                .Where(x => x.Members.Count == 0)
                .ToList();

            //Print teams without members
            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
namespace _09.TeamworkProjects
{
    using System.Collections.Generic;

    public class Team
    {
        public string Name { get; set; }

        public List<string> Members { get; set; }

        public string Creator { get; set; }
    }
}