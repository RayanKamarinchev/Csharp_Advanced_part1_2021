using System;
using System.IO;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader stream=new StreamReader("input.txt"))
            {
                int n = 0;
                string line = await stream.ReadLineAsync();
                while (line != null) 
                {
                    if (n % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = await stream.ReadLineAsync();
                    n++;
                }
            }
        }
    }
}
