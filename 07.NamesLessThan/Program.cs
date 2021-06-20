using System;
using System.Linq;

namespace _07.NamesLessThan
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= n)
                .ToList()
                .ForEach(a => Console.WriteLine(a));
        }
    }
}
