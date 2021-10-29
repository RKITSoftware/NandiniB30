using System;

using System.Collections.Generic;

namespace generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int[] array = { 1, 2, 3, 4, 5 };
            int[] newarray = { 6, 7, 8 };
            list.AddRange(array);
            list.Remove(5);
            foreach (int integer in list)
            {
                Console.Write(integer + ",");

            }

            Console.WriteLine("\n Does arraylist contains 4:" + list.Contains(4));
            list.InsertRange(4, newarray);
            foreach (int integer in list)
            {
                Console.Write(integer + ",");
            }

            //using exists to find a number in the list
            Console.WriteLine("\n No. 4 exists in the list : " + list.Exists(x => x == 4));
            Console.ReadLine();



        }
    }
}