using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(input);
            string[] op = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = op[0].ToUpper();
            while (command!="END")
            {
                switch (command)
                {
                    case "ADD":
                        numbers.Push(int.Parse(op[1]));
                        numbers.Push(int.Parse(op[2]));
                        break;
                    case "REMOVE":
                        int amount = int.Parse(op[1]);
                        if (amount>numbers.Count)
                        {
                            break;
                        }
                        for (int i = 0; i < amount; i++)
                        {
                            numbers.Pop();
                        }
                        break;
                    default:
                        break;
                }
                 op = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                command = op[0].ToUpper();
            }
            Console.WriteLine("Sum: "+numbers.Sum());
        }
    }
}
