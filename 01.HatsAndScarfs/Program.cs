using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.HatsAndScarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>();
            Queue<int> scarfs = new Queue<int>();
            List<int> pairs = new List<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in input)
            {
                hats.Push(item);
            }
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in input2)
            {
                scarfs.Enqueue(item);
            }

            int hat;
            int scarf;
            while (true)
            {
                try
                {
                    hat = hats.Peek();
                    scarf = scarfs.Peek();
                }
                catch (Exception)
                {
                    break;
                }
                if (hat==scarf)
                {
                    scarfs.Dequeue();
                    hats.Pop();
                    hats.Push(hat + 1);
                }
                else if (hat<scarf)
                {
                    hats.Pop();
                }
                else
                {
                    pairs.Add(hat + scarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
            }
            Console.WriteLine($"The most expensive set is: {pairs.Max()}");
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
