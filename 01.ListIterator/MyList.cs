using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01.ListIterator
{
    class MyList<T> : IEnumerable<T>
    {
        public int Index { get; set; }
        public IList<T> Elements { get; set; }

        public MyList(params T[] elements)
        {
            Elements = new List<T>(elements);
            Index = 0;
        }

        public void Create(List<T> elements)
        {
            Elements = new List<T>(elements);
        }
        
        public bool HasNext()
        {
            return Elements.Count > Index + 1;
        }

        public bool Move()
        {
            bool hasNext = HasNext();
            if (hasNext)
            {
                Index++;
            }
            return hasNext;
        }

        public void Print()
        {
            try
            {
                Console.WriteLine(Elements[Index]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
        
        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ",Elements));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
