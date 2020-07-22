using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace Sprint06
{
    class Library1
    {
        private Book[] books;

        public Library1(Book[] books)
        {
            this.books = books;
        }

        public IEnumerable<Book> GеtEnumeratоr()
        {
            for (int i = 0; i < books.Length; i++)
            {
                yield return books[i];
            }
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
