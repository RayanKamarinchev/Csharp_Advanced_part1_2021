using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToArray();
            Stack<string> numbers = new Stack<string>(input);
            while (numbers.Count>1)
            {
                int a = int.Parse(numbers.Pop());
                string operat = numbers.Pop();
                int b = int.Parse(numbers.Pop());
                switch (operat)
                {
                    case "+":
                        numbers.Push((a + b).ToString());
                        break;
                    case "-":
                        numbers.Push((a - b).ToString());
                        break;
                }
            }
            Console.WriteLine(numbers.Pop());
        }
    }
}
