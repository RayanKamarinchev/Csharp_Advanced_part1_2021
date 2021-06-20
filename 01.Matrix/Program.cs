using System;
using System.Linq;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < demensions[0]; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (int num in numbers)
                {
                    sum += num;
                }
            }
            Console.WriteLine(demensions[0]);
            Console.WriteLine(demensions[1]);
            Console.WriteLine(sum);
        }
    }
}
