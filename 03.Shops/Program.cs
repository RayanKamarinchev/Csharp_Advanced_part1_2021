using System;
using System.Collections.Generic;

namespace _03.Shops
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = 
                new SortedDictionary<string, Dictionary<string, double>>();
            string[] command = Console.ReadLine().Split(", ");
            while (command[0].ToUpper()!="REVISION")
            {
                if (shops.ContainsKey(command[0]))
                {
                    shops[command[0]].Add(command[1], double.Parse(command[2]));
                }
                else 
                {
                    shops.Add(command[0],new Dictionary<string, double>());
                    shops[command[0]].Add(command[1], double.Parse(command[2]));
                }
                command = Console.ReadLine().Split(", ");
            }
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
