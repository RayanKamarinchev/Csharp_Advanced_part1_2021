using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int popN = int.Parse(input[1]);
            int searchingN = int.Parse(input[2]);
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            for (int i = 0; i < popN; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(searchingN))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
