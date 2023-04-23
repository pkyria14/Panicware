using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SplitShellcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string srcPath = @"C:\Users\kyria\Desktop\github\donut\splitmimikatz\mimikatz.bin";
            string dstPath = @"C:\Users\kyria\Desktop\github\donut\splitmimikatz\";
            int chunkSize = 1000000;  // split into 1 MB chunks

            int i = 0;
            using (FileStream fileStream = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
            {
                while (true)
                {
                    byte[] chunk = new byte[chunkSize];
                    int count = fileStream.Read(chunk, 0, chunkSize);
                    if (count == 0)
                    {
                        break;
                    }
                    string filename = string.Format("{0}chunk{1:D3}.bin", dstPath, i);
                    File.WriteAllBytes(filename, chunk.Take(count).ToArray());
                    i++;
                }
            }
        }
    }
}
