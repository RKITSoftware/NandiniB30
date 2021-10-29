using System;

namespace protected_access_modifier
{
    class protected_acceses
    {
        //declaring name and message as protected
        protected string name = "Nandini Bhattacharya";
        protected void Message(string message)
        {
            Console.WriteLine("Hello " + message);
        }
    }
    class protected_access_demo
    {
        static void Main(string[] args)
        {
            protected_acceses objprotected = new protected_acceses();
            // Accessing protected variable  
            Console.WriteLine("Hola " + objprotected.name);
            // Accessing protected function  
            objprotected.Message("Adios!");
        }
        //Compile time error
        //'objprotected.name' is inaccessible due to its protection level.
    }
}