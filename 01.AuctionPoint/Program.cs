using System;
using System.Linq;

namespace _01.AuctionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine(n);
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(print);
        }
    }
}
