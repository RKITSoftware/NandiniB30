using System;

namespace Parameterized_Constructor
{
    class constructor
    {
        public int value1, value2;

        // decalaring Paremetrized Constructor with parameter
        public constructor(int input_1, int input_2)  
        {
            value1 = input_1;
            value2 = input_2;
        }
    }
    class constructor_demo
    {
        static void Main()
        {
            // Creating object of Parameterized Constructor and inserting value
            constructor objConstructor = new constructor(10, 15);  
            Console.WriteLine("value_1 : " + objConstructor.value1);
            Console.WriteLine("value_2 :" + objConstructor.value2);
            Console.Read();
        }
    }
}