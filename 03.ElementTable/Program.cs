using System;
using System.Collections.Generic;

namespace _03.ElementTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                foreach (var something in Console.ReadLine().Split())
                {
                    elements.Add(something);
                }
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
