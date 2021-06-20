using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int index = -1;
        public Book Current => books[index];
        object IEnumerator.Current => Current;
        public LibraryIterator(IEnumerable<Book> _books)
        {
            Reset();
            books = new List<Book>(_books);
        }
        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return ++index < books.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
