namespace _06.Book_Library_Modification
{
    using _05.Book_Library;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class LibraryModification
    {
        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());
            Book books = new Book();
            var titleAndReleaseDate = new Dictionary<string, DateTime>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                var currentBook = Console.ReadLine().Split(' ');
                books = new Book
                {
                    Title = currentBook[0],
                    Author = currentBook[1],
                    Publisher = currentBook[2],
                    ReleaseDate = DateTime.ParseExact(currentBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currentBook[4],
                    Price = double.Parse(currentBook[5])
                };

                if (!titleAndReleaseDate.ContainsKey(books.Title))
                {
                    titleAndReleaseDate[books.Title] = new DateTime();
                }

                titleAndReleaseDate[books.Title] = books.ReleaseDate;
            }

            var releaseDateFilter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var result = titleAndReleaseDate.OrderBy(x => x.Value).ThenBy(x => x.Key);

            foreach (var book in result)
            {
                if (book.Value > releaseDateFilter)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value.ToString("dd.MM.yyyy")}");
                }
            }
        }
    }
}
