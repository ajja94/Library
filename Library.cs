using System;
using System.Collections.Generic;
using System.Text;

namespace Libary
{
    static class Library
    {
        public static List<Book> Books { get; set; } = new List<Book>();

        public static void AddDefaultBooksToLibrary()
        {
            Books.Add(new Book("Harry Potter and the philosopher's stone", "J.K Rowling", 281));
            Books.Add(new Book("proggrameringfag", "terje", 993));
            Books.Add(new Book("Harry Potter and the chamber of secrets", "J.K Rowling", 306));
            Books.Add(new Book("Harry Potter and the prisoner of azkaban", "J.K Rowling", 386));
            Books.Add(new Book("Harry Potter and the goblet of fire", "J.K Rowling", 647));
            Books.Add(new Book("Harry Potter and the order of the phoenix", "J.K Rowling", 875));
            Books.Add(new Book("Harry Potter and the half-blood price", "J.K Rowling", 586));
            Books.Add(new Book("Harry Potter and the deathly hallows", "J.K Rowling", 681));
            Books.Add(new Book("Harry Potter and the cursed child", "J.K Rowling", 343));
            Books.Add(new Book("drit i det (hvordan slutte å bruke tid du ikke har på folk du ikke liker", "sarah knight", 203));
            Books.Add(new Book("the Hobbit", "J.R.R. Tolkein", 310));
            Books.Add(new Book("and then there were none", "Agatha Christie", 272));
            Books.Add(new Book("omgitt av idioter", "Thomas Erikson", 294));
        }
    }
}
