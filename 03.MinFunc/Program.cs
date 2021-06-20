using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MinFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(input.Min());
        }
    }
}
