using System;
using System.Linq;

namespace _04.VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList()
                .ForEach(num => Console.WriteLine($"{num*1.2:F2}"));
        }
    }
}
