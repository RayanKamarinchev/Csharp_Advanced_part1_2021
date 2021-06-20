using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            int[] command;
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                switch (command[0])
                {
                    case 1:
                        numbers.Push(command[1]);
                        break;
                    case 2:
                        if (numbers.Count>0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case 4:
                        if (numbers.Count>0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.Write(numbers.Pop());
            while(numbers.Count>0)
            {
                Console.Write(", "+numbers.Pop());
            }
        }
    }
}
