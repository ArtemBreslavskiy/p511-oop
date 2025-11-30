using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Book
    {
        public string Title {  get; private set; }
        public string Author {  get; private set; }
        public string Publisher {  get; private set; }
        public int YearOfPrinting {  get; private set; }
        public int PagesCount {  get; private set; }

        public enum bookArguments
        {
            Title,
            Author,
            Publisher,
            YearOfPrinting,
            PagesCount
        }

        public Book(string title = "Unknown", string author = "Unknown", string publisher = "Unknown", int yearOfPrinting = -1, int pagesCount = -1)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            YearOfPrinting = yearOfPrinting;
            PagesCount = pagesCount;
        }

        public void PrintBook()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"YearOfPrinting: {YearOfPrinting}");
            Console.WriteLine($"PagesCount: {PagesCount}");
        }
    }
}
