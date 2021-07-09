using System;

namespace Learning_C_sharp
{
    class TimeSpanDemo
    {
        public TimeSpanDemo()
        {
            //TimeSpan immutable
            //creating timespan 
            TimeSpan timeSpan1 = new TimeSpan(1, 2, 3);

            TimeSpan timeSpan2 = TimeSpan.FromHours(1);

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(4);
            TimeSpan timeSpan3 = end - start;

            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timeSpan3);


            //propertices
            Console.WriteLine("Minutes: " + timeSpan1.Minutes);
            Console.WriteLine("TotalMinutes: " + timeSpan1.TotalMinutes);

            //add&subtract method
            Console.WriteLine("Add example: {0}", timeSpan1.Add(TimeSpan.FromMinutes(10)));
            Console.WriteLine("Subtract example: {0}", timeSpan1.Subtract(TimeSpan.FromMinutes(10)));

            //tostring
            Console.WriteLine("ToString: " + timeSpan1.ToString());

            //parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:12:45")); // parse convert string into timespance object
        }
    }
}
