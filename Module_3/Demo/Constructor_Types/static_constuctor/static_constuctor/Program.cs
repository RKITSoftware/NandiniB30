using System;

namespace static_Constractor
{
    public class person
    {
        // Static constructor
        static person()
        {
            Console.WriteLine("Hello everyone! ");
        }
        public static void Introduction()
        {
            Console.WriteLine("Name is Nandini...");
        }
    }
    class person_demo
    {
        static void Main()
        {
            Console.WriteLine();
            person.Introduction();
            Console.ReadLine();
        }
    }
}