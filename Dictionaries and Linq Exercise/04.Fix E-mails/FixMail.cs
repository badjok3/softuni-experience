namespace _04.Fix_E_mails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixMail
    {
        public static void Main()
        {
            var mail = Console.ReadLine();
            var names = new List<string>();
            while (mail != "stop")
            {
                names.Add(mail);
                mail = Console.ReadLine();
            }

            var filter = new Dictionary<string, string>();
            for (int i = 0; i < names.Count; i++)
            {
                if (i % 2 == 0)
                {
                    if (!filter.ContainsKey(names[i]))
                    {
                        filter[names[i]] = string.Empty;
                    }
                }

                else
                {
                    filter[names[i - 1]] = names[i];
                }
            }

            var result = new Dictionary<string, string>();
            foreach (var item in filter)
            {
                if (!item.Value.Contains(".us") && !item.Value.Contains(".uk"))
                {
                    result[item.Key] = item.Value;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
