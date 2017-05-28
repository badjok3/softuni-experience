namespace _04.Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var allEvents = new Dictionary<int, Event>();

            while (line != "Time for Code")
            {
                var currentEvent = new Event();
                var pattern = @"(\d+)\s\#([\w\d]+)";
                var matches = Regex.Matches(line, pattern);

                foreach (Match match in matches)
                {
                    var ID = int.Parse(match.Groups[1].ToString());
                    var eventName = match.Groups[2].ToString();

                    var participants = new string[0];
                    var eventHasParticipants = line.Contains("@");

                    if (eventHasParticipants)
                    {
                        participants = line.Substring(line.IndexOf('@')).Split();
                    }

                    if (!allEvents.ContainsKey(ID))
                    {
                        allEvents[ID] = new Event
                        {
                            Name = eventName,
                            Participants = new List<string>(new string[0])
                        };
                    }

                    if (allEvents[ID].Name == eventName)
                    {
                        allEvents[ID].Participants.AddRange(participants);
                        allEvents[ID].Participants = allEvents[ID].Participants.Distinct().ToList();
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var @event in allEvents.OrderByDescending(x=> x.Value.Participants.Count).ThenBy(x=> x.Value.Name))
            {
                Console.WriteLine($"{@event.Value.Name} - {@event.Value.Participants.Count()}");
                foreach (var person in @event.Value.Participants.OrderBy(x=> x))
                {
                    Console.WriteLine(person);
                }
            }
        }
    }

    public class Event
    {
        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }
}