using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyNotFoundException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //declare a dictionary
                var dict = new Dictionary<string, string>() 
                {
                        {"Summer", "Sunglasses"},
                        {"Winter", "Sweater"},
                };
                //try to access the invalid key
                Console.WriteLine(dict["Monsoon"]);
            }
            catch (Exception e)
            {
                // The Message property of the object
				// of type KeyNotFoundException
                Console.WriteLine("Exception:" + e.Message);
                Console.ReadLine();
            }

            //output:-
            //Exception:The given key was not present in the dictionary.
        }
    }
}
