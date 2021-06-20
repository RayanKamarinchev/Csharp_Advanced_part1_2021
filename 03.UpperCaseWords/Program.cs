using System;
using System.Linq;

namespace _03.UpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = str => str[0] == str.ToUpper()[0];
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => predicate(w))
                .ToList()
                .ForEach(w => Console.WriteLine(w));

        }
    }
}
