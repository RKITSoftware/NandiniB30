using System;

namespace Operators
{
    class Program
    {
        private static void Main()
        {
            int a, b, c;
            //concatenation of two strings
            string greet = "Hello" + " World";
            a = 7;
            b = 3;
            c = b++;

            //unary minus implementation
            Console.WriteLine("-a = {0} ", -a);

            //unary plus implementation
            Console.WriteLine("+a = {0} ", +a);

            //  Unary Incremental implementation   
            Console.WriteLine("++a = {0} ",++a);
            Console.WriteLine("a = {0} ",a);
            Console.WriteLine("a++ = {0} ",a++);
            Console.WriteLine("a = {0} ",a);

            // Unary Decrement implementation   
            Console.WriteLine("--a = {0} ",--a);
            Console.WriteLine("a = {0} ",a);
            Console.WriteLine("a-- = {0} ",a--);
            Console.WriteLine("a = {0} ",a);

            b = a + b * c;

            //ternary operator implementation
            c = a >= 100 ? b : c / 2;

            Console.WriteLine("a = {0} ", a);
            Console.WriteLine("b = {0} ", b);
            Console.WriteLine("c = {0} ", c);
            Console.WriteLine("greet = {0}", greet);
            Console.ReadLine();
        }
    }
}
