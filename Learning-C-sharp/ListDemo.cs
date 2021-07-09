
using System;
using System.Collections.Generic;

namespace Learning_C_sharp
{
    class ListDemo
    {
        public ListDemo()
        {
            List<int> list = new List<int>() { 1, 3, 4, 2, 5 };

            //methods
            //Add
            list.Add(8);
            list.Add(1);

            //AddRange
            list.AddRange(new int[] { 3, 6, 7, 5 }); 
            foreach(int n in list)
            {
                Console.WriteLine(n);
            }

            //IndexOf
            Console.WriteLine("IndexOf: "+list.IndexOf(8));
            Console.WriteLine("IndexOf: "+list.IndexOf(10));

            //LastIndexOf
            Console.WriteLine("LastIndexOF: "+list.LastIndexOf(1));

            //Count
            Console.WriteLine("Count: "+list.Count);

            //Remove
            list.Remove(1);
            Console.WriteLine("After remove 1 ");
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }

            //RemoveAll
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == 5)
                {
                    list.Remove(list[i]);
                }
            }
            Console.WriteLine("After Remove all of 5 ");
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }

            //Clear
            list.Clear();
            Console.WriteLine("After clear operation list size is");
            Console.WriteLine(list.Count);
        }       
    }
}
