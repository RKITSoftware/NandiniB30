using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a string
            string str = null;
            try
            {
                //try to access substring of null
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException e)
            {
                //message after catching the exception
                Console.WriteLine("Please check the string str.");
                Console.WriteLine("Exception:" + e.Message);
                Console.ReadLine();
            }

        //output:-
        //Please check the string str.
        //Exception: Object reference not set to an instance of an object.
        }
    }
}
