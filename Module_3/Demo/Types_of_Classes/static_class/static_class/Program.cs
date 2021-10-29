using System;

namespace static_class
{
    // Creating static class using static keyword
    static class Person_Details
    {
        // Static data members of Person_Details
        public static int Age = 21;
        public static string First_name = "Nandini";
        public static string Last_name = "Bhattacharya";

        // Static method of Person_Details
        public static void show_details()
        {
            Console.WriteLine("The details of person is-");
        }
    }

    public class Person_Details_Demo
    {
        static public void Main()
        {

            // Calling static method of static class
            Person_Details.show_details();

            // Accessing the static data members of static class as it cannot be inherited or instantiated
            Console.WriteLine("Age of person : {0} ", Person_Details.Age);
            Console.WriteLine("Person's First name : {0} ", Person_Details.First_name);
            Console.WriteLine("Person's Last name : {0} ", Person_Details.Last_name);
            Console.ReadLine();
        }
    }
}