using System;

namespace sealed_class
{
    sealed public class Personal_information
    {
        public void Show_First_name() 
        { 
            Console.WriteLine("Nandini");
            Console.ReadLine();
        }
        public void Show_Last_name()
        {
            Console.WriteLine("Bhattacharya");
            Console.ReadLine();
        }
    }
    public class Personal_information_demo
    {
        public static void Main()
        {
            Personal_information objName = new Personal_information();
            objName.Show_First_name();
            objName.Show_Last_name();


        }
    }
}