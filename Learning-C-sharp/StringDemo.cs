using System;

namespace Learning_C_sharp
{
    class StringDemo
    {
        public StringDemo()
        {
            string firstName = "Debasish";
            var lastName = "Saha";
            String fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            string[] names = new string[3] { "akash", "mahfuz", "debasish" };
            string formattedNames = string.Join(',', names);
            Console.WriteLine(formattedNames);

            string courseLinkWithGenericWay = "selise.udemy.com\\course\\csharp-tutorial-for-beginners";
            Console.WriteLine(courseLinkWithGenericWay);
            
            string courseLinkWithVarbadiamWay = @"selise.udemy.com\course\csharp-tutorial-for-beginners";
            Console.WriteLine(courseLinkWithVarbadiamWay);
        }
    }
}
