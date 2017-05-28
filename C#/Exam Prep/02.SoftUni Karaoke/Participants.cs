namespace _02.SoftUni_Karaoke
{
    using System.Collections.Generic;

    public class Participants
    {
        public string Name { get; set; }

        public int NumberOfAwards { get; set; }

        public HashSet<string> Awards { get; set; }
    }
}
