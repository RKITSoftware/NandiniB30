using System;

namespace private_Constructor
{
    public class Count
    {
        //private constrctor declaration
        private Count() { }
        public static int current_count;
        public static int resultant_count()
        {
            return ++current_count;
        }
    }
    class show_Count_details
    {
        static void Main()
        {
            // Count objCounter = new Count();   // Error
            Count.current_count = 50;
            Count.resultant_count();
            Console.WriteLine("Now the count is: {0}", Count.current_count);
            Console.ReadLine();
        }
    }
}