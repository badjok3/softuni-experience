namespace _02.Max_Method
{
    using System;

   public class MaxMethod
    {
       public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int finalMax = GetMax(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(finalMax);
        }

        public static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            int firstMax = Math.Max(firstNumber, secondNumber);
            int finalMax = Math.Max(firstMax, thirdNumber);

            return finalMax;
        }
        
    }
}
