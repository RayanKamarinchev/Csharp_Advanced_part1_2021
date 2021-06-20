using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> filesInfo = new Dictionary<string, List<FileInfo>>();
            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                FileInfo information = new FileInfo(file);
                string extention = information.Extension;
                if (!filesInfo.ContainsKey(extention))
                {
                    filesInfo[extention] = new List<FileInfo>();
                }
                filesInfo[extention].Add(information);
            }
            using (StreamWriter write=new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                +"report.txt"))
            {
                foreach (var value in filesInfo.OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    write.WriteLine(value.Key);
                    foreach (var fileInfo in value.Value.OrderBy(x => Math.Ceiling((double)x.Length / 1024)))
                    {
                        write.WriteLine($"--{fileInfo.Name} - {Math.Ceiling((double)fileInfo.Length / 1024)}kb");
                    }
                }
            }
        }
    }
}
