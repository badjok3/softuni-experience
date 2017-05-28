namespace _03.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var line = Console.ReadLine();

            while (line != "print")
            {
                var command = line.Split(' ').ToArray();
                var parameters = new int[command.Length - 1];
                if (command.Length > 1)
                {
                    parameters[0] = int.Parse(command[1]);
                    for (int i = 1; i < command.Length - 1; i++)
                    {
                        parameters[i] = int.Parse(command[i + 1]);
                    }
                }

                if (command[0] == "add")
                {
                    numbers.Insert(parameters[0], parameters[1]);
                }

                else if (command[0] == "addMany")
                {
                    AddMany(numbers, command);
                }

                else if (command[0] == "contains")
                {
                    if (numbers.Contains(parameters[0]))
                    {
                        Console.WriteLine(numbers.IndexOf(parameters[0]));
                    }

                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                else if (command[0] == "remove")
                {
                    numbers.RemoveAt(parameters[0]);
                }

                else if (command[0] == "shift")
                {
                    numbers = ShiftArray(numbers, command);
                }

                else if (command[0] == "sumPairs")
                {
                    numbers = SumPairs(numbers);
                }

                line = Console.ReadLine();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("]");
        }

        public static List<int> ShiftArray(List<int> numbers, string[] command)
        {
            var shiftedList = new int[numbers.Count];
            for (int i = 0; i < int.Parse(command[1]); i++)
            {
                for (int j = 1; j <= numbers.Count; j++)
                {
                    shiftedList[j - 1] = numbers[j % numbers.Count];
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    numbers[j] = shiftedList[j];
                }
            }

            return numbers;
        }

        public static List<int> SumPairs(List<int> numbers)
        {
            List<int> summedPairs = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                summedPairs.Add(numbers[i] + numbers[i + 1]);
            }

            if (numbers.Count % 2 != 0)
            {
                summedPairs.Add(numbers.Last());
            }

            return summedPairs;
        }

        public static List<int> AddMany(List<int> numbers, string[] command)
        {
            var numbersToAdd = new List<int>();
            for (int i = 2; i < command.Length; i++)
            {
                numbersToAdd.Add(int.Parse(command[i]));
            }

            numbers.InsertRange(int.Parse(command[1]), numbersToAdd);
            return numbers;
        }
    }
}

