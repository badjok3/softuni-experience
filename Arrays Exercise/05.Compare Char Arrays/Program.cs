namespace _05.Compare_Char_Arrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            CompareArrays(firstArray, secondArray);
        }

        public static void CompareArrays(char[] firstArray, char[] secondArray)
        {
            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }

            else if (secondArray.Length < firstArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }

            else
            {
                for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                }
            }
        }
    }
}
