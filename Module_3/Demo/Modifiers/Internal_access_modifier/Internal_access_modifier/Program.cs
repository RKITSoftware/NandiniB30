using System;

namespace Internal_access_modifier
{
    class Internal_access
    {
        //declaring name and message as internal
        internal string name = "Nandini Bhattacharya";
        internal void Message(string message)
        {
            Console.WriteLine("Hello " + message);
        }
    }
    class Internal_acces_demo
    {
        static void Main(string[] args)
        {
            Internal_access objinternal = new Internal_access();
            // Accessing internal variable  
            Console.WriteLine("Hola " + objinternal.name);
            // Accessing internal function  
            objinternal.Message("Adios!");
        }
    }
}