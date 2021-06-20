using System;
using System.IO;
using System.Threading.Tasks;

namespace _01.EvenLines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] txt = await File.ReadAllLinesAsync("text.txt");
            for (int i = 0; i < txt.Length; i+=2)
            {
                string[] line = txt[i].Split();
                for (int j = line.Length-1; j >= 0; j--)
                {
                    Console.Write(line[j].Replace(',','@').Replace('.','@').Replace('-','@')
                        .Replace('!','@').Replace('?','@'));
                }
                Console.WriteLine();
            }
        }
    }
}
