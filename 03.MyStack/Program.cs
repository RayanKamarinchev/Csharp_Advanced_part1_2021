using System;
using System.Linq;

namespace _03.MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            MyStack<string> stack = new MyStack<string>(command.Skip(1).ToList());
            command = Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0]!="END")
            {
                if (command[0]=="Push")
                {
                    stack.Push(command.Skip(1).Select(t=>t.Split(',').First()).ToArray());
                }
                else if (command[0]=="Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("No elements");
                    }
                }
                command = Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
