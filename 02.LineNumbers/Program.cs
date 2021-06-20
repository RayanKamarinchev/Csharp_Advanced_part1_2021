using System;
using System.IO;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader stream = new StreamReader("input.txt"))
            {
                int n = 1;
                string line = await stream.ReadLineAsync();
                using (StreamWriter wrt=new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        await wrt.WriteLineAsync($"{n}. {line}");
                        line = await stream.ReadLineAsync();
                        n++;
                    }
                }

            }
        }
    }
}
