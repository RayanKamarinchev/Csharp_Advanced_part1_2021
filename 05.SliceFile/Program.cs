using System;
using System.IO;
using System.Threading.Tasks;

namespace _05.SliceFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            long parts = 4;
            byte[] buffer = new byte[4096];
            int totalBytes = 0;
            using (FileStream fs = new FileStream("sliceMe.txt", FileMode.Open, FileAccess.Read)) 
            {
                long partsSize = (long)Math.Ceiling((decimal)fs.Length / parts);
                for (int i = 1; i <= parts; i++)
                {
                    int readBytes = 0;
                    using (FileStream oFs = new FileStream($"Part-{i}.txt", FileMode.Create, FileAccess.Write))
                    {

                        while (readBytes < partsSize && totalBytes < fs.Length) 
                        {
                            int bytes = await fs.ReadAsync(buffer, 0, buffer.Length);
                            await oFs.WriteAsync(buffer, 0, bytes);
                            readBytes += bytes;
                            totalBytes += bytes;
                        }
                    }
                }
            }            
        }
    }
}
