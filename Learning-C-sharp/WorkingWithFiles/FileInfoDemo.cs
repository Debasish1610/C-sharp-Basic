using System;
using System.IO;

namespace Learning_C_sharp.WorkingWithFiles
{
    class FileInfoDemo
    {
        public FileInfoDemo()
        {
            string filePath = @"I:\code\C sharp\Learning-C-sharp\Learning-C-sharp\text-files\demo-file.txt";

            // FileInfo provides instance methods. That means we have to create object before access its properties.
            FileInfo fileInfo = new FileInfo(filePath); 

            fileInfo.CopyTo(@"I:\code\C sharp\Learning-C-sharp\Learning-C-sharp\text-files\copy-file.txt", true);

            //fileInfo.Delete();

            Console.WriteLine(fileInfo.Exists);
        }
    }
}