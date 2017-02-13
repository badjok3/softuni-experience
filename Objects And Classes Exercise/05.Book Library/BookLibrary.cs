namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
       public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());
            Book books = new Book();
            var authorAndPrice = new Dictionary<string, double>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                var currentBook = Console.ReadLine().Split(' ');
                books = new Book
                {
                    Title = currentBook[0],
                    Author = currentBook[1],
                    Publisher = currentBook[2],
                    ReleaseDate = currentBook[3],
                    ISBN = currentBook[4],
                    Price = double.Parse(currentBook[5])
                };

                if (!authorAndPrice.ContainsKey(books.Author))
                {
                    authorAndPrice[books.Author] = 0;
                }


                authorAndPrice[books.Author] += books.Price;
            }

            var result = authorAndPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var book in result)
            {
                Console.WriteLine($"{book.Key} -> {book.Value:f2}");
            }
        }
    }
}
