namespace _01.Odd_Lines
{
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(input[i]);
                }
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
