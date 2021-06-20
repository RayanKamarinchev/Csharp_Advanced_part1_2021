﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Box
{
    class Box<T>
    {
        private readonly List<T> elements= new List<T>();
        public int Count { get { return elements.Count; } }

        public void Add(T element)
        {
            elements.Add(element);
        }

        public T Remove()
        {
            T result = elements.LastOrDefault();
            elements.Remove(result);
            return result;
        }
    }
}
