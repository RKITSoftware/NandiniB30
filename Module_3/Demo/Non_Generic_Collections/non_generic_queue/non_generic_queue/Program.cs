using System;
using System.Collections;

namespace non_generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue random = new Queue();
            random.Enqueue("Nandini");
            random.Enqueue("bhattacharya");
            random.Enqueue(21);
            random.Enqueue(5.2);

            foreach (var elements in random)
            {
                Console.Write(elements);
            }

            //Element at the top
            Console.WriteLine("Element at the top is: " + random.Peek());

            //Does it contain no. 21
            Console.WriteLine("Does it contain no. 21: " + random.Contains(21));

            random.Dequeue();

            //Does it contain word Nandini
            Console.WriteLine("Does it contain word Smit: " + random.Contains("Nandini"));
        }
    }
}