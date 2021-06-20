using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int space = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(input);
            int sum = 0;
            int racks = 0;
            while (clothes.Count>0)
            {
                sum += clothes.Pop();
                if (clothes.Count==0)
                {
                    racks++;
                    break;
                }
                if (sum+clothes.Peek()>space)
                {
                    racks++;
                    sum = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
