using System;

namespace InterfaceDemo
{
    //interface having methods to draw shapes
    interface IDrawShape
    {
        //draw rectangle
        void drawRectangle();

        //draw triangle
        void drawTriangle();
    }

    //interface having methods showing number edges of shape
    interface IShapeTrait
    {
        //method for number of edges of rectangle
        void Rectangle_edges();

        //method for number of edges of triangle
        void Triangle_edges();
    }

    //class with single interface inheritance
    public class Shape: IDrawShape
    {
        public void drawRectangle()
        {
            Console.WriteLine("drawing rectangle...");
        }

        public void drawTriangle()
        {
            Console.WriteLine("drawing triangle...");
        }
    }

    //class with multiple interface inheritance
    public class Shape_info: IDrawShape,IShapeTrait
    {
        public void drawRectangle()
        {
            Console.WriteLine("drawing rectangle...");
        }

        public void Rectangle_edges()
        {
            Console.WriteLine("Number of edges in a rectangle are 4.");
        }

        public void drawTriangle()
        {
            Console.WriteLine("drawing triangle...");
        }

        public void Triangle_edges()
        {
            Console.WriteLine("Number of edges in a triangle are 3.");
        }
    }

    class find_shape_info
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making of shapes:");
            //object of class Shape
            Shape objShape_making = new Shape();
            //perform all inherited methods
            objShape_making.drawRectangle();
            objShape_making.drawTriangle();

            //output:-
            //Making of shapes:
            //drawing rectangle...
            //drawing triangle...

            Console.WriteLine("Finding number of edges of mentioned shapes:");
            //object of class Shape_info
            Shape_info objShape_info = new Shape_info();
            //perform all inherited methods
            objShape_info.drawRectangle();
            objShape_info.Rectangle_edges();
            objShape_info.drawTriangle();
            objShape_info.Triangle_edges();
            Console.ReadLine();
            
            //output:-
            //Finding number of edges of mentioned shapes:
            //drawing rectangle...
            //Number of edges in a rectangle are 4.
            //drawing triangle...
            //Number of edges in a triangle are 3.
        }
    }
}
