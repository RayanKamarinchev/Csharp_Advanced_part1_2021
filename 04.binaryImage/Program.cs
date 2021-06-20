using System;
using System.IO;

namespace _04.binaryImage
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("copyMe.png", FileMode.Open))
            using (FileStream writer=new FileStream("CopiedImage.png",FileMode.Create))
                while (reader.CanRead)
                {
                    byte[] buffer = new byte[4096];
                    int byteRead = reader.Read(buffer, 0, buffer.Length);
                    if (byteRead == 0)
                    {
                        break;
                    }
                    writer.Write(buffer, 0, byteRead);
                }
        }
    }
}
