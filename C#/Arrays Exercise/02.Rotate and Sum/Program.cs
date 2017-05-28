namespace _02.Rotate_and_Sum
{
    using System;

    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            // Read array from console
            string values = Console.ReadLine();
            int rotateTimes = int.Parse(Console.ReadLine());
            string[] parameters = values.Split(' ');
            int[] numbers = new int[parameters.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(parameters[i]);
            }
            
            //Shift arrays with ShiftArray and sum their values
            var result = new int[numbers.Length];
            for (int i = 1; i <= rotateTimes; i++)
            {
                numbers = ShiftArray(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                result[j] += numbers[j];
                }
            }

            // Print array
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }

        public static int[] ShiftArray(int[] numbers)
        {
            int[] shiftedArray = new int[numbers.Length];

            for (int i = 1; i < numbers.Length; i++)
            {
                shiftedArray[i] = numbers[i - 1];
            }

            shiftedArray[0] = numbers[shiftedArray.Length-1];
            return shiftedArray;
        }
    }
}
