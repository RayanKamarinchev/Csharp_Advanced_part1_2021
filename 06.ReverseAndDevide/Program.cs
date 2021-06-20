using System;
using System.Linq;

namespace _06.ReverseAndDevide
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            numbers.Where(n=>n%x!=0).Reverse()
                .ToList()
                .ForEach(n => Console.Write(n + " "));
        }
    }
}
