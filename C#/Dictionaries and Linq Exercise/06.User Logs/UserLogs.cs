namespace _06.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var logs = new SortedDictionary<string, Dictionary<string, int>>();
            var ipCount = new Dictionary<string, int>();
            while (line != "end")
            {
                var currentIP = GetIP(line);
                var currentUser = GetUsername(line);
                if (!logs.ContainsKey(currentUser))
                {
                    logs[currentUser] = new Dictionary<string, int>();
                }

                if (logs[currentUser].ContainsKey(currentIP))
                {
                    logs[currentUser][currentIP]++;
                }

                else
                {
                    logs[currentUser][currentIP] = 1;
                }

                line = Console.ReadLine();
            }

            foreach (var user in logs)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine(string.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value).ToArray()) + ".");
            }

        }

        public static string GetIP(string line)
        {
            var parameters = line.Split(' ');
            var seperator = parameters[0].Split('=');
            var IP = seperator[1];

            return IP;
        }

        public static string GetUsername(string line)
        {
            var parameters = line.Split(' ');
            var user = parameters[2].Split('=');
            var username = user[1].ToString();

            return username;
        }
    }
}
