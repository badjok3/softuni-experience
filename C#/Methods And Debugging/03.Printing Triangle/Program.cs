namespace _03.Printing_Triangle
{
    using System;

    class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintColumns(row);
            }

            for (int row = number - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
