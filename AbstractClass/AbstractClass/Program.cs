using System;

namespace AbstractClass
{
    abstract class Rectangle
    {
        public abstract void AreaOfRect();
    }
    abstract class Polygon : Rectangle
    {
        public int Len { get; set; }
        public abstract void Area();
        public void Volume()
        {
            Console.WriteLine($"This non-abstract method Volume() with Len = {Len}");
        }
    }

    class Triangle : Polygon
    {
        public override void Area()
        {
            Console.WriteLine($"This abstract method Area() with Len = {Len}");
        }
        public override void AreaOfRect()
        {
            Console.WriteLine("Area of rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Triangle();
            rect.AreaOfRect();

            Polygon poly = new Triangle();
            poly.Len = 10;
            poly.Area();
            poly.Volume();
            poly.AreaOfRect();

            Triangle tri = new Triangle();
            tri.Len = 15;
            tri.Area();
            tri.Volume();
            tri.AreaOfRect();
        }
    }
}
