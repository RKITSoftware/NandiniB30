using System;

namespace Copy_Constractor
{
    class Person
    {
        private string name;
        private int age;

        // declaring Copy constructor
        public Person(Person objInfo)   
        {
            name = objInfo.name;
            age = objInfo.age;
        }

        // Instance constructor
        public Person(string name, int age)  
        {
            this.name = name;
            this.age = age;
        }

        // Get deatils of person
        public string Details     
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }
    }
    class person_detail
    {
        static void Main()
        {
            // Create a new Person object.
            Person objInfo_1 = new Person("Nandini", 21);

            // here is objInfo_1 details is copied to objInfo_2
            Person ObjInfo_2 = new Person(objInfo_1);          
            Console.WriteLine(ObjInfo_2.Details);
            Console.ReadLine();
        }
    }
}