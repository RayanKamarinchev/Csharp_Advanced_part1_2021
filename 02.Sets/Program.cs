using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetLeanght = arr[0];
            int secondSetLeanght = arr[1];
            int minSet = Math.Min(firstSetLeanght, secondSetLeanght);
            int[] numbers1 = new int[firstSetLeanght];
            int[] numbers2 = new int[secondSetLeanght];
            HashSet<int> pairs = new HashSet<int>();

            for (int i = 0; i < firstSetLeanght; i++)
            {
                numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondSetLeanght; i++)
            {
                numbers2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < minSet; i++)
            {
                if (numbers2.Contains(numbers1[i]))
                {
                    pairs.Add(numbers1[i]);
                }
            }
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
