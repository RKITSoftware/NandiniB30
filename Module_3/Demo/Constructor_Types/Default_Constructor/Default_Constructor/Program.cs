using System;

namespace Default_Constructor
{
    class Name
    {
        //local variables.
        public string first_name,last_name;

        #region Default Constructor
        public Name()
        {
            first_name = "Nandini";
            last_name = " Bhattacharya";
        }
        #endregion Default Constructor
    }

    class Name_demo
    {
        static void Main(string[] args)
        {
            //object created.
            var objName = new Name();

            Console.WriteLine("Name : " + (objName.first_name + objName.last_name));
            Console.ReadLine();
        }
    }
}