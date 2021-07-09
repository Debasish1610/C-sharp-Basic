using System;

namespace Learning_C_sharp.MoreAboutString
{
    class StringEssential
    {
        public StringEssential()
        {
            string name = "debasish Saha ";

            //Trim()
            Console.WriteLine("Trim: " + name.Trim());

            //ToUpper
            Console.WriteLine("ToUpper: " + name.ToUpper());

            //ToLower
            Console.WriteLine("ToLower: " + name.ToLower());

            //IndexOf
            Console.WriteLine("IndexOf: " + name.IndexOf(' '));

            //Substring
            Console.WriteLine("Substring: " + name.Substring(0, 8));
            Console.WriteLine("Substring: " + name.Substring(9));

            //spilt
            var names = name.Split(" ");
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            //Replace
            Console.WriteLine("Replace: " + name.Replace(' ', '_'));
            Console.WriteLine("Replace: " + name.Replace(" ", "_"));

            //IsNullOrEmpty
            Console.WriteLine("IsNullOrEmpty: " + String.IsNullOrEmpty(""));
            Console.WriteLine("IsNullOrEmpty: " + String.IsNullOrEmpty(null));
            Console.WriteLine("IsNullOrEmpty: " + String.IsNullOrEmpty("asdfas"));

            //IsNullOrWhiteSpace
            Console.WriteLine("IsNullOrWhiteSpace: " + String.IsNullOrWhiteSpace(" "));

            //Convert
            var age = "25";
            Console.WriteLine("parse: " + int.Parse(age));
            Console.WriteLine("Convert: " + Convert.ToInt32(age));
        }
    }
}
