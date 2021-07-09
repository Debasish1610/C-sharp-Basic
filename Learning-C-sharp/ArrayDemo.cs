using System;

namespace Learning_C_sharp
{
    class ArrayDemo
    {
        public ArrayDemo()
        {
            // linear array.
            int[] arr = new int[] { 3, 4, 5, 6, 1 };
            int[] arr2 = new int[4];

            //methods
            //Length
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr2.Length);

            //IndexOf
            Console.WriteLine(Array.IndexOf(arr, 6));
            Console.WriteLine(Array.IndexOf(arr, 10));

            //Clear
            Array.Clear(arr, 3, 0);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Copy
            Array.Copy(arr, arr2, 3);
            Console.WriteLine("Copy");
            foreach(int n in arr2)
            {
                Console.WriteLine(n);
            }

            //Sort
            Array.Sort(arr2);
            Console.WriteLine("Sort");
            foreach(var n in arr2)
            {
                Console.WriteLine(n);
            }

            //Reverse
            Array.Reverse(arr2);
            Console.WriteLine("Reverse");
            foreach(var n in arr2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
