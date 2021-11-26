using System;

namespace Inheritance
{
    class Polygon
    {
        internal int w, h;
        public Polygon() 
        { 
            Console.WriteLine("Polygon Constructor"); 
        }
        public Polygon(int w,int h)
        {
            //Console.WriteLine("Polygon Constructor");
            this.w = w;
            this.h = h;
        }
        public void valueOf()
        {
            Console.WriteLine("Width = {0} & Height = {1}",w,h);
        }
        public void Area()
        {
            Console.WriteLine("Area in polygon");
        }
    }
    class Rectangle : Polygon
    {
        public Rectangle() 
        { 
            Console.WriteLine("Rectangle Constructor"); 
        }
        public Rectangle(int w, int h)
        {
            //Console.WriteLine("Rectangle Constructor");
            this.w = w;
            this.h = h;
        }
        public new void Area()
        {
            //valueOf();
            Console.WriteLine("Area of rectangle = {0}", w *h);
        }
    }
    class Triangle : Rectangle
    {
        public Triangle() 
        { 
            //Console.WriteLine("Triangle Constructor"); 
        }
        public Triangle(int w, int h)
        {
            //Console.WriteLine("Triangle Constructor");
            this.w = w;
            this.h = h;
        }
        public new void Area()  // Method hiding
        {
            //base.Area();
            Console.WriteLine("Area of triangle = {0}",w * h * 0.5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Polygon re = new Rectangle();
            re.Area();
            Rectangle rect = new Rectangle();
            Rectangle rect1 = new Rectangle(12,21);
            rect.w = 25;
            rect.h = 12;
            //rect.Area();
            //rect.valueOf();
            ((Polygon)rect).Area();

            Console.WriteLine();
            Triangle tri = new Triangle();
            Triangle tri1 = new Triangle(20,40);
            tri.w = 20;
            tri.h = 22;
            //tri.valueOf();
            ((Rectangle)tri).Area();
            
        }
    }
}
