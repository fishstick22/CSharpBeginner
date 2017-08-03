using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\jburkholder\Documents\Visual Studio 2017\Projects\C Sharp Basics for Beginners\C Sharp Basics for Beginners.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("File name without Extensions: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
        }
    }
}
