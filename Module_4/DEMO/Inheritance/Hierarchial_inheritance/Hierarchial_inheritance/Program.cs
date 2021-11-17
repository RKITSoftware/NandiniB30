using System;

namespace Hierarchial_inheritance
{
    //base class
    public class Parent
    {
        //base class constructor
        public Parent()
        {
            Console.WriteLine("Constructor Parent called.");
        }

        //base class method
        public void DisplayParent_info()
        {
            Console.WriteLine("Monika and Debjit are my parents");
        }
    }

    //derived class
    public class Child_elder : Parent
    {
        //derived class constructor
        public Child_elder()
        {
            Console.WriteLine("Constructor Child_elder called.");
        }

        //derived class method
        public void DisplayChild_elder_info()
        {
            Console.WriteLine("I am the elder child, Navin.");
        }
    }

    //derived class
    public class Child_younger : Parent
    {
        //derived class constructor
        public Child_younger()
        {
            Console.WriteLine("Constructor Child_younger called.");
        }

        //derived class method
        public void DisplayChild_younger_info()
        {
            Console.WriteLine("I am the younger child, Nandini.");
        }
    }

    public class Hierarchial_inheritance_demo
    {
        public static void Main(string[] args)
        {
            //creating objects og class
            Child_elder objChild_elder = new Child_elder();
            Child_younger objChild_younger = new Child_younger();

            // accessing base and derived class
            objChild_elder.DisplayChild_elder_info();
            objChild_elder.DisplayParent_info();

            // accessing base and derived class
            objChild_younger.DisplayChild_younger_info();
            objChild_younger.DisplayParent_info();
            Console.ReadLine();

            //output:-
            //Constructor Parent called.
            //Constructor Child_elder called.
            //Constructor Parent called.
            //Constructor Child_younger called.
            //I am the elder child, Navin.
            //Monika and Debjit are my parents
            //I am the ypunger child, Nandini.
            //Monika and Debjit are my parents
        }
    }
}