using System.Collections;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly SortedSet<Book> books;
        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
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
}
