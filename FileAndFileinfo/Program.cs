using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.FileAndFileinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\stuff.txt";

            File.Copy(@"c:\temp\somefile1.txt", @"c:\temp\somefile2.txt");
            File.Delete(path);
            if (File.Exists(path))
            {
                // do something
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                // do something
            }
        }
    }
}
