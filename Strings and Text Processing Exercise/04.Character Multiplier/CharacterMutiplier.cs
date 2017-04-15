namespace _04.Character_Multiplier
{
    using System;

    class CharacterMutiplier
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(' ');
            var firstWord = line[0];
            var secondWord = line[1];
            var result = 0;

            for (int i = 0; i < Math.Max(firstWord.Length, secondWord.Length); i++)
            {
                if (i < Math.Min(firstWord.Length, secondWord.Length))
                {
                    result += firstWord[i] * secondWord[i];
                }

                else
                {
                    if (firstWord.Length >= secondWord.Length)
                    {
                        result += firstWord[i];
                    }

                    else
                    {
                        result += secondWord[i];
                    }
                }

            }

            Console.WriteLine(result);
        }
    }
}
