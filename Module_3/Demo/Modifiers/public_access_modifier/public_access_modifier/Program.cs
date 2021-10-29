using System;
namespace public_access_modifiers
{
    class public_access
    {
        //declaring name and message as public
        public string name = "Nandini Bhattacharya";
        public void Message(string message)
        {
            Console.WriteLine("Hello " + message);
            Console.ReadLine();
        }
    }
    class public_access_demo
    {
        static void Main(string[] args)
        {
            public_access objpublic = new public_access();
            // Accessing public variable  
            Console.WriteLine("Hola " + objpublic.name);
            // Accessing public function  
            objpublic.Message("Adios!");
        }
    }
}