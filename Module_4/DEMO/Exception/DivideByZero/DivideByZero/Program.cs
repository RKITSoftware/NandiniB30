using System;

namespace DivideByZero_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //divide an integer value with zero
                int result = 15 / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                //message after catching the exception
                Console.WriteLine("Exception:" + e.Message);
                Console.ReadLine();
            }

            //output:-
            //Exception:Attempted to divide by zero.
        }
    }
}
