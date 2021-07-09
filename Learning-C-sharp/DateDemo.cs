using System;

namespace Learning_C_sharp
{
    class DateDemo
    {
        public DateDemo()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(dateTime);
            Console.WriteLine(now);
            Console.WriteLine(today);

            //methods
            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(tomrrow);
            Console.WriteLine(yesterday);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd")); //format Specifier
        }
    }
}
