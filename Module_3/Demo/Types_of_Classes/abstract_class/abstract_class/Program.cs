using System;

namespace abstract_class
{
    // abstract class 
    public abstract class Personal_information
    {
        //abstract method 
        public abstract void show();
    }
    public class First_Name : Personal_information
    {
        //show Abstract class here
        public override void show()
        {
            //content of the abstract class
            Console.WriteLine("Nandini");
            Console.ReadLine();
        }
    }
    public class Last_Name : Personal_information
    {
        //show Abstract class here
        public override void show()
        {
            //content of the abstract class
            Console.WriteLine("Bhattacharya");
            Console.ReadLine();
        }
    }
    public class Personal_information_demo
    {
        public static void Main()
        {
            //below is the object of class Personal_information
            Personal_information objPerson;

            //we can call the abstract class method here.
            objPerson = new First_Name();
            objPerson.show();
            objPerson = new Last_Name();
            objPerson.show();
        }
    }
}
