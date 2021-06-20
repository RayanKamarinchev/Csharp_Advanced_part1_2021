using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GetEvenOrOddInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string filter = Console.ReadLine();
            Predicate <int> predicate= filter == "odd" 
                ? number => number % 2 != 0 
                : new Predicate<int>(number => number % 2 == 0);
            List<int> result = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
