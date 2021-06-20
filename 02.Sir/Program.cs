using System;
using System.Linq;

namespace _02.Sir
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine("Sir "+n);
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(print);
        }
    }
}
