namespace _02.Array_Manipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            while (command != "end")
            {
                var parameters = command.Split(' ');

                switch (parameters[0])
                {
                    case "exchange":
                        {
                            var index = int.Parse(parameters[1]);
                            if (index < 0 || index > array.Length)
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }

                            array = ArrayExchange(array, index + 1);
                            break;
                        }

                    case "min":
                    case "max":
                        {
                            Console.WriteLine(GetIndex(array, parameters[0], parameters[1]));
                            break;
                        }

                    case "first":
                    case "last":
                        {
                            Console.WriteLine(GetSequence(array, parameters[0], parameters[2], int.Parse(parameters[1])));
                            break;
                        }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        
        
        public static int[] ArrayExchange(int[] array, int index)
        {
            if (index < 0 || index > array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            return array.Skip(index).Concat(array.Take(index)).ToArray();
        }

        public static string GetIndex(int[] array, string type, string pairity)
        {
            var remainder = pairity == "odd" ? 1 : 0;
            var filtered = array.Where(x => x % 2 == remainder).ToArray();

            if (!filtered.Any())
            {
                return "No matches";
            }

            return type == "min"
               ? Array.LastIndexOf(array, filtered.Min()).ToString()
               : Array.LastIndexOf(array, filtered.Max()).ToString();
        }

        public static string GetSequence(int[] array, string type, string pairity, int count)
        {
            if (count > array.Length)
            {
                return "Invalid count";
            }

            int remainder = pairity == "odd" ? 1 : 0;
            int[] filterd = array.Where(x => x % 2 == remainder).ToArray();

            return type == "first"
                ? "[" + string.Join(", ", filterd.Take(count)) + "]"
                : "[" + string.Join(", ", filterd.Reverse().Take(count).Reverse()) + "]";
        }
    }
}
