using System;
using System.Text;

namespace Learning_C_sharp.MoreAboutString
{
    class StringBuilderDemo
    {
        public StringBuilderDemo()
        {
            // Append and AppendLine method
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("name");
            Console.WriteLine(stringBuilder);
            stringBuilder.Append('.', 5);
            Console.WriteLine(stringBuilder);
            stringBuilder.AppendLine();
            stringBuilder.Append('_', 20);
            Console.WriteLine(stringBuilder);

            //Replace
            stringBuilder.Replace('_', '+');
            Console.WriteLine(stringBuilder);

            //Remove
            stringBuilder.Remove(0, 5);
            Console.WriteLine(stringBuilder);

            //Insert
            stringBuilder.Insert(0, "name");
            Console.WriteLine(stringBuilder);

            //Accessing each character
            Console.WriteLine(stringBuilder[2]);

            //Chain operation
            stringBuilder.Append('-', 6).Append('+', 10);
            Console.WriteLine(stringBuilder);
        }
    }
}



