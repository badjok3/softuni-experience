namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var people = Console.ReadLine();
            var phoneBook = new Dictionary<string, string>();
            while (people != "END")
            {
                var parameters = people.Split(' ');
                if (parameters[0] == "A")
                {
                    phoneBook[parameters[1]] = parameters[2];
                }

                else
                {
                    if (phoneBook.ContainsKey(parameters[1]))
                    {
                        foreach (var item in phoneBook)
                        {
                            if (item.Key == parameters[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine($"Contact {parameters[1]} does not exist.");
                    }
                }

                people = Console.ReadLine();
            }

        }
    }
}
