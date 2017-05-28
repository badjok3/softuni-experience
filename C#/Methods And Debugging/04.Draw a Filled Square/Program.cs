namespace _04.Draw_a_Filled_Square
{
    using System;

    public class PrintASquare
    {

        public static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            PrintHeader(squareSize);
            PrintMiddle(squareSize);
            PrintHeader(squareSize);
        }

        public static void PrintHeader(int headerSize)
        {

            Console.WriteLine(new string('-', headerSize * 2));
        }

        public static void PrintMiddle(int middleSize)
        {
            for (int i = 1; i <= middleSize - 2; i++)
            {
                Console.Write('-');

                for (int rows = 1; rows < middleSize; rows++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }
    }
}
