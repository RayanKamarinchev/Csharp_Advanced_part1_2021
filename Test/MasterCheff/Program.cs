using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterCheff
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dishes = new SortedDictionary<string, int>();
            dishes.Add("Dipping sauce",0);
            dishes.Add("Green salad", 0);
            dishes.Add("Chocolate cake", 0);
            dishes.Add("Lobster", 0);
            Queue<int> ingredient = new Queue<int>();
            Stack<int> fresh = new Stack<int>();
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> stackInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < input.Count; i++)
            {
                ingredient.Enqueue(input[i]);
            }
            for (int i = 0; i < stackInput.Count; i++)
            {
                fresh.Push(stackInput[i]);
            }
            while (true)
            {
                int currIngradient = ingredient.Peek();
                int currFreash = fresh.Peek();
                while (currIngradient==0)
                {
                    ingredient.Dequeue();
                    if (ingredient.Count == 0 || fresh.Count == 0)
                    {
                        break;
                    }
                    currIngradient = ingredient.Peek();
                }
                if (ingredient.Count == 0 || fresh.Count == 0)
                {
                    break;
                }
                int multiply = currFreash * currIngradient;
                switch (multiply)
                {
                    case 150:
                        dishes["Dipping sauce"]++;
                        break;
                    case 250:
                        dishes["Green salad"]++;
                        break;
                    case 300:
                        dishes["Chocolate cake"]++;
                        break;
                    case 400:
                        dishes["Lobster"]++;
                        break;
                    default:
                        ingredient.Enqueue(currIngradient + 5);
                        break;
                }
                ingredient.Dequeue();
                fresh.Pop();
                if (ingredient.Count == 0 || fresh.Count == 0)
                {
                    break;
                }
            }
            SortedDictionary<string, int> output = new SortedDictionary<string, int>();
            foreach (var item in dishes)
            {
                if (item.Value > 0)
                {
                    output.Add(item.Key, item.Value);
                }
            }
            if (output.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            if (ingredient.Count > 0&&ingredient.Sum()!=0)
            {
                Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
            }
            foreach (var item in output)
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }
        }
    }
}
