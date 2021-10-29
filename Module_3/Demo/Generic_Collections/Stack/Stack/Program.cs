using System;
using System.Collections.Generic;

public class generic_Stack
{
    public static void Main(string[] args)
    {
        Stack<int> num = new Stack<int>();
        num.Push(10);
        num.Push(15);
        num.Push(1);
        num.Push(18);
        num.Push(12);

        foreach (int value in num)
        {
            Console.WriteLine(value);
        }

        //elelment at top
        Console.WriteLine("Peek element: " + num.Peek());

        //pop an element
        Console.WriteLine("Pop: " + num.Pop());
        Console.WriteLine("After Pop, Peek element: " + num.Peek());

        //check whether stack contains 2
        Console.WriteLine("Does numbers contain 9:" + num.Contains(2));

    }
}