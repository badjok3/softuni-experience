namespace _08.Mentor_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class MentorGroup
    {
        public static void Main()
        {
            var students = new Dictionary<string, Student>();
            while (true)
            {
                var online = new Student();

                var inputDates = Console.ReadLine();
                if (inputDates == "end of dates") break;

                while (inputDates != "end of dates")
                {
                    var info = inputDates.Split(' ', ',').ToList();
                    var username = info[0];
                    if (!students.ContainsKey(username))
                    {
                        online = new Student();
                        online.Dates = new List<DateTime>();

                        foreach (var date in info.Skip(1))
                        {
                            var day = DateTime.ParseExact(date,
                                 "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            online.Dates.Add(day);
                        }
                    }
                    else if (students.ContainsKey(username))
                    {
                        foreach (var date in info.Skip(1))
                        {
                            var day = DateTime.ParseExact(date,
                                "dd/MM/yyyy",
                                CultureInfo.InvariantCulture);
                            students[username].Dates.Add(day);
                        }
                        inputDates = Console.ReadLine();
                        continue;
                    }
                    students[username] = online;
                    inputDates = Console.ReadLine();
                }
                var commenting = Console.ReadLine();

                while (commenting != "end of comments")
                {
                    var info = commenting.Split('-').ToArray();
                    var username = info[0];
                    var comment = info[1];

                    if (students.ContainsKey(username))
                    {
                        if (students[username].Comments == null)
                        {
                            students[username].Comments = new List<string>();
                        }
                        students[username].Comments.Add(comment);
                    }
                    commenting = Console.ReadLine();
                }
                break;
            }
            foreach (var student in students.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");
                if (student.Value.Comments != null)
                {
                    foreach (var comment in student.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
