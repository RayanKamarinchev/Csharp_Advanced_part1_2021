using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.GenericCount
{
    public class Box<T>: IComparable<T> where T:IComparable<T>
    {
        public Box(T type)
        {
            Element = type;
        }

        public Box(List<T> list)
        {
            Elements = list;
        }
        public List<T> Elements { get; }
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

        int IComparable<T>.CompareTo(T other)
        {
            return Element.CompareTo(other);
        }
        public int CountOfGreaterElements<T>(List<T> list,T readline) where T : IComparable
        {
            return list.Count(word => word.CompareTo(readline) > 0);
        }
    }
}
