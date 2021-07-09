using System;

namespace Learning_C_sharp
{
    public enum Color
    {
        RED = 1, 
        GREEN = 2, 
        BLUE = 3
    }

    class EnumDemo
    {
        public EnumDemo()
        {
            var color = Color.BLUE;
            Console.WriteLine(color);
            Console.WriteLine((int)color); // if I cast into integer then we will see the value of enum property. 
            Console.WriteLine((Color)3); // if I cast integer into enum type then we will see the enum property according to that value.

            var anyColor = (Color)Enum.Parse(typeof(Color), "BLUE");
            if(Color.BLUE == anyColor)
            {
                Console.WriteLine("Successfully convert string to enum");
            }
        }
    }
}
