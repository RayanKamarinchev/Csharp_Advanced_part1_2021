using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] someWords = await File.ReadAllLinesAsync("words.txt");
            string[] input = await File.ReadAllLinesAsync("text.txt");
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var line in input)
            {
                string[] txt = line.Split(new string[] { " ", ",", ".", "?", "!" ,"-"},StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < txt.Length; i++)
                {
                    foreach (var wordToSearch in someWords)
                    {
                        if (txt[i].ToLower()==wordToSearch.ToLower())
                        {
                            if (words.ContainsKey(wordToSearch))
                            {
                                words[wordToSearch]++;
                            }
                            else
                            {
                                words.Add(wordToSearch, 1);
                            }
                        }
                    }
                }
            }
            string[] results = new string[words.Count];
            int currentLine = 0;
            foreach (var word in words)
            {
                results[currentLine] = $"{word.Key} - {word.Value}";
                currentLine++;
            }
             await File.AppendAllLinesAsync("actuallResult.txt",results);
        }
    }
}
