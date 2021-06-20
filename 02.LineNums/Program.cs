using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _02.LineNums
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] txt = await File.ReadAllLinesAsync("text.txt");
            string[] allText = new string[txt.Length];
            for (int i = 0; i < txt.Length; i++)
            {
                 allText[i]=($"Line{i+1}:{txt[i]}({CountLetters(txt[i])})({CountMarks(txt[i])})");
            }
            await File.WriteAllLinesAsync("output.txt",allText);
        }
        static int CountLetters(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i]>=65&&text[i]<=90)||(text[i]>=97&&text[i]<=122))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountMarks(string text)
        {
            int count = 0;
            foreach (var word in text.Split())
            {
                foreach (var letter in word)
                {
                    count++;
                }
            }
            return count-CountLetters(text);
        }
    }
}
