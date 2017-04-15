namespace _02.Command_Interpreter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine();

            while (command != "end")
            {
                var parameter = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (parameter[0])
                {
                    case "reverse":
                        {
                            int start = int.Parse(parameter[2]);
                            int count = int.Parse(parameter[4]);

                            if (IsValid(array, start, count))
                            {
                                array.Reverse(start, count);
                            }

                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }

                            break;
                        }

                    case "sort":
                        {
                            int sortStart = int.Parse(parameter[2]);
                            int sortCount = int.Parse(parameter[4]);

                            if (IsValid(array, sortStart, sortCount))
                            {
                                array.Sort(sortStart, sortCount, StringComparer.InvariantCulture);
                            }

                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }

                            break;
                        }

                    case "rollLeft":
                        {
                            int count = int.Parse(parameter[1]);
                            if (count >= 0)
                            {
                                RollLeft(array, count);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                            break;
                        }

                    case "rollRight":
                        {
                            int count = int.Parse(parameter[1]);
                            if (count >= 0)
                            {
                                RollRight(array, count);
                            }

                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                            break;
                        }
                }


                command = Console.ReadLine();
            }


            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void RollRight(List<string> array, int count)
        {
            count = count % array.Count;
            for (int i = 0; i < count; i++)
            {
                string lastElem = array[array.Count - 1];
                array.RemoveAt(array.Count - 1);
                array.Insert(0, lastElem);

            }
        }

        private static void RollLeft(List<string> array, int count)
        {
            count = count % array.Count;
            for (int i = 0; i < count; i++)
            {
                var firstElem = array[0];
                array.RemoveAt(0);
                array.Insert(array.Count, firstElem);
            }

        }

        private static bool IsValid(List<string> line, int start, int count)
        {
            if (start >= 0 && start < line.Count && count >= 0 && (start + count) <= line.Count)
            {
                return true;
            }

            return false;
        }
    }
}