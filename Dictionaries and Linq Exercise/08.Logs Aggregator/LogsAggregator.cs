namespace _08.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var numberOfLogs = int.Parse(Console.ReadLine());
            var userLogs = new SortedDictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberOfLogs; i++)
            {
                var currentLog = Console.ReadLine().Split(' ');
                var adress = currentLog[0];
                var user = currentLog[1];
                var stayTime = long.Parse(currentLog[2]);


                if (!userLogs.ContainsKey(user))
                {
                    userLogs[user] = new Dictionary<string, long>();
                }

                if (userLogs[user].ContainsKey(adress))
                {
                    userLogs[user][adress] += stayTime;
                }

                else
                {
                    userLogs[user].Add(adress, stayTime);
                }


            }

            foreach (var user in userLogs)
            {
                var timeDictionary = user.Value;
                var totalTime = timeDictionary.Values.Sum();

                Console.Write($"{user.Key}: ");
                Console.Write($"{totalTime} [");

                var IPList = new List<string>();
                foreach (var IP in user.Value)
                {
                    IPList.Add(IP.Key);
                }

                IPList.Sort();
                var result = string.Join(", ", IPList);
                Console.Write(result);
                Console.WriteLine("]");
            }
        }
    }
}
