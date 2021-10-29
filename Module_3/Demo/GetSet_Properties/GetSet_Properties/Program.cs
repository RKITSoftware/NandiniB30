using System;

namespace GetSet_Properties
{
    class Personal_Information
    {
        //properties Getter and setter is used to set or get value.
        public static string name { get; set; }
        public static int age { get; set; }
    }
    class Personal_Information_demo
    {
        static void Main(string[] args)
        {
            //set the value.
            Personal_Information.name = "Nandini Bhattacharya";
            Personal_Information.age = 21;

            //get the value.
            Console.WriteLine("Name : " + Personal_Information.name);
            Console.WriteLine("Age : " + Personal_Information.age);
            Console.ReadLine();
        }
    }
}