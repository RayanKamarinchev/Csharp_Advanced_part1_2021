using System;
using System.Collections.Generic;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> str = new Stack<char>();
            string txt = Console.ReadLine();

            for (int i = 0; i < txt.Length; i++)
            {
                str.Push(txt[i]);
            }

            while (str.Count > 0) 
            {
                Console.Write(str.Pop());
            }
        }
    }
}
