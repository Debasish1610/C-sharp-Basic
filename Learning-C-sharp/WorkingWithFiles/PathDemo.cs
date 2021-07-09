using System;
using System.IO;

namespace Learning_C_sharp.WorkingWithFiles
{
    class PathDemo
    {
        public PathDemo()
        {
            string filePath = @"I:\code\C sharp\Learning-C-sharp\Learning-C-sharp\text-files\demo-file.txt";

            Console.WriteLine("Extension: " + Path.GetExtension(filePath));
            Console.WriteLine("Get file name: " + Path.GetFileName(filePath));
            Console.WriteLine("Get file name without extension: " + Path.GetFileNameWithoutExtension(filePath));
            Console.WriteLine("Get directory: " + Path.GetDirectoryName(filePath));
        }
    }
}