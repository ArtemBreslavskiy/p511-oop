using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static p511_oop.Book;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {
                new Book("George Orwell", "1984", "Penguin Books", 1949, 328),
                new Book("J.K. Rowling", "Harry Potter", "Bloomshury", 1997, 223),
                new Book("Война и мир", "Лев Толстой", "Русский вестник", 1869, 1225),
                new Book("Преступление и наказание", "Фёдор Достоевский", "Русский вестник", 1866),
                new Book("Мастер и Маргарита", "Михаил Булгаков", "Москва", 1967, 480),
                new Book("Евгений Онегин", "Александр Пушкин", "Азбука", 1833, 384),
                new Book("Мёртвые души", "Николай Гоголь", "Советский писатель", 1842, 352),
            };

            Book[] filteredBooks = FilteredBooks(books, bookArguments.Author, "Николай Гоголь");

            foreach (Book book in filteredBooks)
            {
                book.PrintBook();
                Console.WriteLine();
            }
        }

        static public Book[] FilteredBooks(Book[] books, bookArguments argument, string value)
        {
            int[] numbesCorrectBooks = new int[books.Length];
            switch (argument)
            {
                case bookArguments.Title:

                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].Title == value)
                        {
                            numbesCorrectBooks[i] = i + 1;
                        }
                    }
                    break;

                case bookArguments.Author:

                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].Author == value)
                        {
                            numbesCorrectBooks[i] = i + 1;
                        }
                    }
                    break;

                case bookArguments.Publisher:

                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].Publisher == value)
                        {
                            numbesCorrectBooks[i] = i + 1;
                        }
                    }
                    break;
            }
            int truesCounter = 0;

            foreach (int i in numbesCorrectBooks)
                if (i != 0) truesCounter++;

            Book[] FilteredBooks = new Book[truesCounter];
            int j = 0;

            foreach (int i in numbesCorrectBooks)
            {
                if (i != 0)
                {
                    FilteredBooks[j] = books[i - 1];
                    j++;
                }
            }

            return FilteredBooks;
        }

        static public Book[] PrintFilteredBooks<T>(Book[] books, bookArguments argument, int value)
        {
            int[] numbesCorrectBooks = new int[books.Length];
            switch (argument)
            {
                case bookArguments.YearOfPrinting:

                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].YearOfPrinting == value)
                        {
                            numbesCorrectBooks[i] = i + 1;
                        }
                    }
                    break;

                case bookArguments.PagesCount:

                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].PagesCount == value)
                        {
                            numbesCorrectBooks[i] = i + 1;
                        }
                    }
                    break;
            }
            int truesCounter = 0;

            foreach (int i in numbesCorrectBooks)
                if (i != 0) truesCounter++;

            Book[] FilteredBooks = new Book[truesCounter];
            int j = 0;

            foreach (int i in numbesCorrectBooks)
            {
                if (i != 0)
                {
                    FilteredBooks[j] = books[i - 1];
                    j++;
                }
            }

            return FilteredBooks;
        }
    }
}
