using System;
using System.Collections.Generic;
using System.Text;

namespace Libary
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Pages { get; private set; }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        internal void PrintBook()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Pages: {Pages}");
        }
    }
}
