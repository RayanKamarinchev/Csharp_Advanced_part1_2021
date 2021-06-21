using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.MyStack
{
    class MyStack<T> : IEnumerable<T>
    {
        public List<T> Elements;

        public MyStack(List<T> elements)
        {
            Elements = elements;
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                Elements.Insert(Elements.Count, item);
            }
        }

        public T Pop()
        {
            if (Elements.Count == 0)
            {
                throw new ArgumentException("No Elements");
            }
            T element = Elements[Elements.Count - 1];
            Elements.RemoveAt(Elements.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Elements.Count-1; i >= 0; i--)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
