using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Swap
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            var box = new Box<int>(list);
            int[] command= Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(list, command[0], command[1]);
            Console.WriteLine(box);
        }
    }
}
