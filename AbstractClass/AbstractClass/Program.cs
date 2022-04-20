using System;

namespace AbstractClass
{
    abstract class Polygon
    {
        public virtual void Area() { Console.WriteLine("This is default area"); }
    }
    class Triangle : Polygon
    {
        public override void Area()
        {
            Console.WriteLine("Area of Triangle");
        }
    }
    abstract class Quadrilateral : Polygon
    {
        public override void Area()
        {
            Console.WriteLine("Area of Quadrilateral");
        }
        public abstract void AreaOfQuadrilateral();
        
    }
    class Rectangle : Quadrilateral
    {
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle");
        }
        public override void AreaOfQuadrilateral()
        {
            Console.WriteLine("Area of a Quadrilateral");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Polygon poly = new Triangle();
            poly.Area();
            Console.WriteLine();

            Triangle tri = new Triangle();
            tri.Area();
            Console.WriteLine();

            Quadrilateral quad = new Rectangle();
            quad.Area();
            quad.AreaOfQuadrilateral();
            Console.WriteLine();

            Rectangle rect = new Rectangle();
            rect.Area();
            rect.AreaOfQuadrilateral();
        }
    }
}
