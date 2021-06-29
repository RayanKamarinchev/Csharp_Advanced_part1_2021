using System;
using System.Collections.Generic;
using System.Linq;

namespace _21.CPU
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks= new Stack<int>();
            Queue<int> threads = new Queue<int>();
            List<int> input1 = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < input1.Count; i++)
            {
                tasks.Push(input1[i]);
            }
            for (int i = 0; i < input2.Count; i++)
            {
                threads.Enqueue(input2[i]);
            }
            int targetTask = int.Parse(Console.ReadLine());
            while (true)
            {
                int currTask = tasks.Peek();
                int currThread= threads.Peek();
                if (currTask==targetTask)
                {
                    break;
                }
                if (currThread>=currTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                    continue;
                }
                else
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {threads.Peek()} killed task {targetTask}");
            Console.WriteLine(string.Join(" ",threads));
        }
    }
}
