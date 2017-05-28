namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var numberOfItems = int.Parse(Console.ReadLine());
            var itemProperties = new Dictionary<string, decimal>();

            //Adds valid snacks to itemProperties
            for (int i = 0; i < numberOfItems; i++)
            {
                var currentItem = Console.ReadLine().Split('-');
                if (!itemProperties.ContainsKey(currentItem[0]))
                {
                    itemProperties[currentItem[0]] = 0;
                }

                itemProperties[currentItem[0]] = decimal.Parse(currentItem[1]);
            }

            var clients = Console.ReadLine();
            List<Customer> students = new List<Customer>();
            while (clients != "end of clients")
            {
                var parameters = clients.Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                // Checks if item is valid
                if (itemProperties.ContainsKey(parameters[1]))
                {
                    Customer currentClient = new Customer
                    {
                        Name = parameters[0],
                        ShopList = new SortedDictionary<string, int>()
                    };

                    // Checks if student has ordered anything before
                    if (students.Any(n => n.Name == parameters[0]))
                    {
                        currentClient = students.First(n => n.Name == parameters[0]);

                        //Adds each item to the ShopList and calculated the bill 
                        for (int i = 1; i < parameters.Length; i += 2)
                        {
                            if (!currentClient.ShopList.ContainsKey(parameters[i]))
                            {
                                currentClient.ShopList.Add(parameters[i], int.Parse(parameters[i + 1]));
                                currentClient.Bill += int.Parse(parameters[i + 1]) * itemProperties[parameters[i]];
                            }

                            else
                            {
                                currentClient.ShopList[parameters[i]] += int.Parse(parameters[i + 1]);
                                currentClient.Bill += int.Parse(parameters[i + 1]) * itemProperties[parameters[i]];
                            }
                        }
                    }

                    //If student hasn't ordered anything before
                    else
                    {
                        currentClient.ShopList.Add(parameters[1], int.Parse(parameters[2]));
                        currentClient.Bill = int.Parse(parameters[2]) * itemProperties[parameters[1]];
                        students.Add(currentClient);
                    }
                }

                clients = Console.ReadLine();
            }

            // Sort students list and print result
            var ordered = students.OrderBy(x => x.Name).ThenBy(x => x.Bill);
            foreach (var student in ordered)
            {
                Console.WriteLine(student.Name);
                foreach (var item in student.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {student.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {students.Sum(x => x.Bill):f2}");
        }
    }
}
