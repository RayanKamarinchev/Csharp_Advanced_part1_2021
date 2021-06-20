using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Queue<string> childrens = new Queue<string>(input);
            int n = int.Parse(Console.ReadLine());

            while (childrens.Count>1)
            {
                for (int i = 1; i < n; i++)
                {
                    childrens.Enqueue(childrens.Dequeue());
                }
                Console.WriteLine($"Removed {childrens.Dequeue()}");
            }
            Console.WriteLine($"Last is {childrens.Dequeue()}");
        }
    }
}
