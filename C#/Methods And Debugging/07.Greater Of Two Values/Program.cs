namespace _07.Greater_Of_Two_Values
{
    using System;

    public class GetGreaterValue
    {
        public static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int userInt = int.Parse(Console.ReadLine());
                int secondUserInt = int.Parse(Console.ReadLine());
                int result = GetMax(userInt, secondUserInt);

                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char userChar = char.Parse(Console.ReadLine());
                char secondUserChar = char.Parse(Console.ReadLine());
                char result = GetMax(userChar, secondUserChar);

                Console.WriteLine(result);
            }
            else
            {
                string userString = Console.ReadLine();
                string secondUserString = Console.ReadLine();
                string result = GetMax(userString, secondUserString);

                Console.WriteLine(result);
            }
        }

        public static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt >= secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }

        public static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        public static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}
