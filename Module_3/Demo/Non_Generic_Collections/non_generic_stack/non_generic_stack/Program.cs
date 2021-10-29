using System;
using System.Collections;

namespace non_generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack random = new Stack();
            random.Push("Nandini");
            random.Push("bhattacharya");
            random.Push(21);
            random.Push(5.2);

            foreach (var elements in random)
            {
                Console.Write(elements);
            }

            //Element at the top
            Console.Write("Element at the top is: " + random.Peek());
            
            //Does it contain no. 21
            Console.Write("Does it contain no. 21: " + random.Contains(21));
 
            random.Pop();
            
            //Does it contain double 5.2
            Console.Write("Does it contain double 5.12: " + random.Contains(5.2));         
        }
    }
}