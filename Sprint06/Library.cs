using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sprint06
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }
    }

    public class Library : IEnumerable<Book>
    {
        public Library(IEnumerable<Book> books)
        {
            Books = books;
        }

        public IEnumerable<Book> Books { get; }
        public Predicate<Book> Filter { get; set; } = (item) => true;
        public IEnumerator<Book> GetEnumerator() => new MyEnumerator(Books, Filter);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class MyEnumerator : IEnumerator<Book>
    {
        private Book[] books;
        private int position = -1;

        public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
        {
            this.books = Array.FindAll(books.ToArray(), filter);
        }

        public Book Current
        {
            get
            {
                if (position == -1 || position >= books.Length)
                    throw new InvalidOperationException();
                return books[position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (position < books.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset() => position = -1;

        public void Dispose()
        {
        }
    }

    public class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book> predicate) =>
            new Library(books) { Filter = predicate }.ToList();
    }
}