using System;
using System.Collections.Generic;

public class generic_Queue
{
    public static void Main(string[] args)
    {
        Queue<int> num = new Queue<int>();
        num.Enqueue(10);
        num.Enqueue(4);
        num.Enqueue(12);
        num.Enqueue(26);
        num.Enqueue(2);

        foreach (int value in num)
        {
            Console.WriteLine(value);
        }

        //element at top
        Console.WriteLine("Peek element: " + num.Peek());
        
        //element popped
        Console.WriteLine("Dequeue: " + num.Dequeue());
        Console.WriteLine("After Dequeue, Peek element: " + num.Peek());

        //checks whether queue contain 1
        Console.WriteLine("Does numbers contain 1:" + num.Contains(1));
        Console.ReadLine();
    }
}