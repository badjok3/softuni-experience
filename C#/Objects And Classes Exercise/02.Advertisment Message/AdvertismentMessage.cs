namespace _02.Advertisment_Message
{
    using System;

    public class AdvertismentMessage
    {
        public static void Main()
        {
            var advertismentNumber = int.Parse(Console.ReadLine());

            var phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var author = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var town = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var random = new Random();

            var phraseResult = phrases[random.Next(0, phrases.Length)];
            var eventsResult = events[random.Next(0, events.Length)];
            var authorResult = author[random.Next(0, author.Length)];
            var townResult = town[random.Next(0, town.Length)];
            Console.WriteLine($"{phraseResult} {eventsResult} {authorResult} - {townResult}");
        }
    }
}
