using System;

namespace Learning_C_sharp
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
        }
    }
}
