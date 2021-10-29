using System;
using System.Collections;

namespace non_generic_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // adding elements using ArrayList.Add() method
            ArrayList arlist = new ArrayList();
            arlist.Add(1);
            arlist.Add("Cat");
            arlist.Add(4.5);
            arlist.Add(null);

            string secondElement = (string)arlist[1]; //returns "Cat"
            //int secondElement = (int) arlist[1]; //Error: cannot cover string to int
            Console.WriteLine(secondElement);

            //using var keyword without explicit casting
            var firstValue = arlist[0]; //returns 1
            var secondValue = arlist[1]; //returns "Cat"
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);

            //update elements
            arlist[0] = 2;

            //insert an element at particular index
            arlist.Insert(1, "Second");

            foreach (var val in arlist)
            {
                Console.Write(val);
            }

            //Removes first occurance of null
            arlist.Remove(null);
            //Removes element at index 4
            arlist.RemoveAt(3);
            //Removes two elements starting from 1st item (0 index)
            arlist.RemoveRange(0, 2);

            foreach (var val in arlist)
                Console.Write(val);

            Console.WriteLine(arlist.Contains("Cat"));
            Console.ReadLine();

        }
    }
}
