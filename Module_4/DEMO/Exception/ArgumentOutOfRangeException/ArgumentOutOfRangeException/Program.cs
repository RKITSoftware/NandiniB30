using System;
using System.Collections.Generic;

namespace ArgumentOutOfRangeException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            list.AddRange(new String[] { "A", "B", "C" });
            try
            {
                // Display the elements in the list by index.
                for (int list_element = 0; list_element <= list.Count; list_element++)
                {
                    Console.WriteLine("Index {0}: {1}", list_element, list[list_element]);
                }
            }

            //catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }

            //finally block
            finally
            {
                Console.WriteLine("This is an exception demo.");
                Console.ReadLine();
            }

            //output:-
            //Index 0: A
            //Index 1: B
            //Index 2: C
            //Exception:Index was out of range. Must be non - negative and less than the size of the collection.
            //Parameter name: index
            //This is an exception demo.
        }
    }
}
