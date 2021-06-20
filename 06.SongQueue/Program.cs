using System;
using System.Collections.Generic;

namespace _06.SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(input);
            string[] command;
            while (songs.Count>0)
            {
                command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string theSong = NameSong(command);
                        if (songs.Contains(theSong))
                        {
                            Console.WriteLine($"{theSong} is already contained!");
                            break;
                        }
                        songs.Enqueue(theSong);
                        break;
                    case "Show":
                        string[] showSongs = songs.ToArray();
                        Console.Write(showSongs[0]);
                        for (int i = 1; i < songs.Count; i++)
                        {
                            Console.Write(", "+showSongs[i]);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
        static string NameSong(string[] full)
        {
            string song = "";
            for (int i = 1; i < full.Length; i++)
            {
                song += full[i];
                if (full.Length-1!=i)
                {
                    song += " ";
                }
            }
            
            return song;
        }
    }
}
