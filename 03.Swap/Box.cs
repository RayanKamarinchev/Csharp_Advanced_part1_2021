using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Swap
{
    public class Box<T>
    {
        public Box(T type)
        {
            Element = type;
        }

        public Box(List<T> list)
        {
            Elements = list;
        }
        public List<T> Elements { get;}
        public T Element { get; }

        public void Swap(List<T> elements, int index1, int index2)
        {
            T first = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = first;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
