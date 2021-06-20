using System;
using System.Linq;

namespace _05.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = (int[])Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Action<int[]> printer = n => Console.WriteLine(string.Join(" ",n));
            string command = Console.ReadLine();
            while (command!="end")
            {
                if (command=="add")
                {
                    numbers = ForEach(numbers, number => ++number);
                }
                else if (command == "multiply")
                {
                    numbers = ForEach(numbers, number => number*2);
                }
                else if (command == "subtract")
                {
                    numbers = ForEach(numbers, number => --number);
                }
                else if (command == "print")
                {
                    printer(numbers);
                }
                command = Console.ReadLine(); 
            }
        }

        public static int[] ForEach(int[] nums, Func<int,int> func)
        {
            return nums.Select(n => func(n)).ToArray();
        }
    }
}
