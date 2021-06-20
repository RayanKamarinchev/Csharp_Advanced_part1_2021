using System;
using System.Collections.Generic;

namespace _06.Warbode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> warbode = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (warbode.ContainsKey(input[0])==false)
                {
                    warbode.Add(input[0], new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    if (warbode[input[0]].ContainsKey(input[j]))
                    {
                        warbode[input[0]][input[j]]++;
                    }
                    else
                    {
                        warbode[input[0]].Add(input[j], 1);
                    }
                }
            }
            string[] clothe = Console.ReadLine().Split();
            foreach (var colors in warbode)
            {
                Console.WriteLine($"{colors.Key} clothes: ");
                foreach (var cloth in colors.Value)
                {
                    if (colors.Key==clothe[0]&&cloth.Key==clothe[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
