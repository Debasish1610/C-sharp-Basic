using System;
using System.IO;

namespace Learning_C_sharp.WorkingWithFiles
{
    class FileDemo
    {   
        public FileDemo()
        {
            // File provides static methods
            string filePath = @"I:\code\C sharp\Learning-C-sharp\Learning-C-sharp\text-files\demo-file.txt";

            File.Copy(filePath, @"I:\code\C sharp\Learning-C-sharp\Learning-C-sharp\text-files\copy-file.txt", true);

            //File.Delete(filePath);

            Console.WriteLine(File.Exists(filePath));

            Console.WriteLine(File.ReadAllText(filePath));

        }
    }
}