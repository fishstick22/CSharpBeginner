using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            //var files = Directory.GetFiles(@"C:\Users\jburkholder\Documents\Visual Studio 2017\Projects\C Sharp Basics for Beginners", "*.sln");
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"C:\Users\jburkholder\Documents\Visual Studio 2017\Projects", 
                "*.*", SearchOption.TopDirectoryOnly);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
            
        }
    }
}
