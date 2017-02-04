namespace _02.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var people = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();
            while (people != "END")
            {
                if (people == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }

                    people = Console.ReadLine();
                }
                else
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
}
