using System;

namespace OverridingVsHiding
{
    class Drawing
    {
        public void Draw()
        {
            Console.WriteLine("This is for draw");
        }
    }
    class Line : Drawing
    {
        public new void Draw()   // new for method hiding of base class's method
        {
            //base.Draw();
            Console.WriteLine("This is a line");
        }
    }
    //class Circle : Line
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("This is a circle");
    //    }
    //}
    //class Square : Drawing
    //{
    //    public  void Draw()
    //    {
    //        Console.WriteLine("This is a square");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Drawing draw = new Drawing(); 
            //draw.Draw(); // Calls own method
            //Line line = new Line();
            //line.Draw(); // Calls own method

            Drawing1 draw1 = new Drawing1();
            //draw1.Draw(); // Calls own method
            Line1 line1 = new Line1();
            line1.Draw(); // Calls own method
            line1.len = 21; // Calls own member 
            ((Drawing1)line1).len = 21; // Calls Drawing1 class's member

            Drawing1 draw2 = new Line1(); // Creating base class obj of derived type
            //draw2.Draw(); // It'll call Drawing.Draw() if it's not overriden,otherwise Line1.Draw() 

            Circle1 circle1 = new Circle1();
            circle1.Draw();
            circle1.len = 10;

            Line1 circle2 = new Circle1();
            circle2.Draw();
            circle2.len = 11;

            Drawing1 circle3 = new Circle1();
            circle3.Draw();
            circle3.len = 12;

        }
    }
}
