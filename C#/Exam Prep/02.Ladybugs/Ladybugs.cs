namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldLength = int.Parse(Console.ReadLine());
            var bugIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var command = Console.ReadLine();
            var field = new int[fieldLength];

            for (int i = 0; i < bugIndex.Length; i++)
            {
                if (bugIndex[i] >= 0 && bugIndex[i] < fieldLength)
                {
                    field[bugIndex[i]] = 1;
                }
            }

            while (command != "end")
            {
                var parameter = command.Split(' ');
                var index = int.Parse(parameter[0]);
                var direction = parameter[1];
                var flyLength = int.Parse(parameter[2]);

                if (index < 0 || index >= field.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                else if (field[index] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                else if (field[index] == 1)
                {
                    if (direction == "right")
                    {
                        if (flyLength > 0)
                        {
                            MoveRight(field, index, flyLength);
                        }

                        else
                        {
                            MoveLeft(field, index, Math.Abs(flyLength));
                        }
                    }

                    else
                    {
                        if (flyLength > 0)
                        {
                            MoveLeft(field, index, flyLength);
                        }

                        else
                        {
                            MoveRight(field, index, Math.Abs(flyLength)); ;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        public static void MoveLeft(int[] field, int index, int flyLength)
        {
            if (index - flyLength < 0)
            {
                field[index] = 0;
            }

            else
            {
                field[index] = 0;

                for (int i = index - flyLength; i > -1; i -= flyLength)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }

                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
        }

        public static void MoveRight(int[] field, int index, int flyLength)
        {
            if (index + flyLength >= field.Length)
            {
                field[index] = 0;
            }

            else
            {
                field[index] = 0;
                for (int i = index + flyLength; i < field.Length; i += flyLength)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }

                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
        }
    }
}
