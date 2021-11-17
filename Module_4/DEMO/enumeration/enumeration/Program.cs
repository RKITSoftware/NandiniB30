using System;

namespace enumeration
{
    //declare an enum 
    public enum colour
    {
        Red,
        Green=2,
        Yellow,
        Blue=7,
        Orange
    }

    class enumeration_demo
    {
        static void Main(string[] args)
        {
            //explicit type conversion from enum to int
            int var_yellow = (int)colour.Yellow;
            int var_blue = (int)colour.Blue;

            //Value of colour yellow : 3
            Console.WriteLine("Value of colour yellow : {0} ", var_yellow);

            // Value of colour blue : 7
            Console.WriteLine("Value of colour blue : {0} ", var_blue);

            //conversion of an int value to enum value
            int colour_value = 2;
            colour find_colour = (colour)colour_value;

            // The colour is Green
            Console.WriteLine("The colour is {0}", find_colour);

            //get the integer value of the enum members
            Array enumColourValue = Enum.GetValues(typeof(colour));
            foreach (int enumValue in enumColourValue)
            {
                // get the value/name of the enum members
                string colorValue = Enum.GetName(typeof(colour), enumValue);
                Console.WriteLine($"Name: {colorValue} and value : {enumValue}");
            }
            Console.ReadLine();
        }
    }
}
