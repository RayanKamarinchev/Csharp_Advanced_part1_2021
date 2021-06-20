﻿using System.Collections;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
