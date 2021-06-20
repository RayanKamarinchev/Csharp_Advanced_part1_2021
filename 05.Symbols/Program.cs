using System;
using System.Collections.Generic;

namespace _05.Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            for (int i = 0; i < txt.Length; i++)
            {
                if (symbols.ContainsKey(txt[i]))
                {
                    symbols[txt[i]]++;
                }
                else
                {
                    symbols.Add(txt[i], 1);
                }
            }
            foreach (var character in symbols)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
