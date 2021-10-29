using System;
using System.Collections.Generic;

namespace generic_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> fruits = new SortedList<int, string>()
            {
                {4,"apple" },
                {3,"watermelon" },
                {1,"grape" }
            };

            fruits.Add(2, "orange");
            foreach (KeyValuePair<int, string> kvp in fruits)
            {
                Console.WriteLine("Rank is: " + kvp.Key + " fruit: " + kvp.Value);
            }

            Console.WriteLine();
            if (fruits.ContainsKey(3))
            {
                fruits[3] = "strawberry";
            }

            Console.WriteLine("Rank is: " + 3 + " fruit: " + fruits[3]);
            
            //remove element from index position 1
            fruits.RemoveAt(1);
            Console.WriteLine();
            foreach (KeyValuePair<int, string> kvp in fruits)
            {
                Console.WriteLine("Rank is: " + kvp.Key + " fruit: " + kvp.Value);
            }
            
        }
    }
}