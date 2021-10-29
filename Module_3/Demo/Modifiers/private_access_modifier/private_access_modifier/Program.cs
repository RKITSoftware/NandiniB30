using System;

namespace private_ccess_modifier
{
    class private_access
    {
        private string name = "Nandini Bhattacharya";
        private void Message(string message)
        {
            Console.WriteLine("Hello " + message);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            private_access objprivate = new private_access();
            // Accessing private variable  
            Console.WriteLine("Hola " + objprivate.name);
            Console.ReadLine();
            // Accessing private function  
            objprivate.Message("Adios!");
        }
    }
}