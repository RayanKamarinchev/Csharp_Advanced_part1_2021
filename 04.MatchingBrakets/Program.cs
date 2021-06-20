using System;
using System.Collections.Generic;

namespace _04.MatchingBrakets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> index = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    index.Push(i);
                }
                else if (input[i]==')')
                {
                    int index1 = index.Pop();
                    Console.WriteLine(input.Substring(index1, i - index1 + 1));
                }
            }
        }
    }
}
