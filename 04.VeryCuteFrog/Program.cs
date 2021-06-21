using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.VeryCuteFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake<string> lake = new Lake<string>();
            lake.Stones = Console.ReadLine().Split(", ").ToList();
            lake.MoveFrog();
        }
    }
}
