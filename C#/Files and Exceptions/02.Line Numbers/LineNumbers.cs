namespace _02.Line_Numbers
{
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                result.Add($"{i + 1}. {input[i]}");
            }

            File.WriteAllLines("output.txt", result);
        }
    }
}
