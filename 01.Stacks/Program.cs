using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int popN = int.Parse(input[1]);
            int searchingN = int.Parse(input[2]);
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            for (int i = 0; i < popN; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(searchingN))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
