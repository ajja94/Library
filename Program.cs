using System;
using System.Collections.Generic;

namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.AddDefaultBooksToLibrary();

            Console.WriteLine("welcome to the library, explore books and add new books");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Your input please: ");
                var input = Console.ReadLine().ToLower();
                if (input == "add")
                {
                    Library.Books.Add(CreateNewBook());
                }
                else if (input == "search")
                {
                    SearchForBook();
                }
                else if (input == "count")
                {

                    PrintBookCount();
                }
                else if (input == "")
                {
                    break;
                }
                else
                {
                    PrintHelp();
                }

            }
        }

        private static void SearchForBook()
        {
            Console.Write("please input book title for search: ");

            var inputTitle = Console.ReadLine();

            var foundBooks = new List<Book>();

            foreach (var book in Library.Books)
            {
                if (book.Title.ToLower().Contains(inputTitle.ToLower()))
                {
                    Console.WriteLine();
                    foundBooks.Add(book);
                    book.PrintBook();
                }
            }
            if(foundBooks.Count == 0)
            {
                Console.WriteLine("no book by this name is found, please add the book to the libarary");
            }

           // library.Find(b => b.Title.Contains(inputTitle));
        }

        private static void PrintHelp()
        {
            Console.WriteLine("type add to add new book");
            Console.WriteLine("type count to get the size of library");
            Console.WriteLine("type search to lookup books");
            Console.WriteLine("type enter to end ");

        }

        private static void PrintBookCount()
        {
            var count = Library.Books.Count;
            Console.WriteLine($"it is {count} book(s) in the library");
        }

        private static Book CreateNewBook()
        {
            string bookTitle;
            string bookAuthor;
            int pages;

            while (true)
            {
                Console.Write("Enter a book title: ");
                bookTitle = Console.ReadLine();
                if (bookTitle == "")
                {
                    continue;
                }

                break;

            }
            while (true)
            {
                Console.Write("Enter a book author: ");
                bookAuthor = Console.ReadLine();
                if (bookAuthor == "")
                {
                    continue;
                }

                break;

            }
            while (true)
            {
                Console.Write("Enter pages amount: ");
                try
                {
                    pages = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    continue;
                }

                if (pages < 1)
                {
                    continue;
                }

                break;

            }
            return new Book(bookTitle, bookAuthor, pages);


        }
    }
}
