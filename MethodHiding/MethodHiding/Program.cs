using System;

namespace MethodHiding
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
    class Square : Drawing
    {
        public new void Draw()   // new for method hiding of base class's method
        {
            Console.WriteLine("This is a Square");
        }
    }
    class Circle : Square
    {
        public new void Draw()   // new for method hiding of base class's method
        {
            Console.WriteLine("This is a Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drawing draw = new Drawing();
            draw.Draw(); // Calls own method
            Line line = new Line();
            line.Draw(); // Calls own method
            Square square = new Square();
            square.Draw(); // Calls own method
            Console.WriteLine();
            
            Drawing[] draw2 = new Drawing[]
            {
                new Line(),  
                new Square()
            };
            draw2[0].Draw();  // Instance of Line type, Calling Base Drawing.Draw()
            draw2[1].Draw();  // Instance of Square type, Calling Base Drawing.Draw()
            Console.WriteLine();
            
            ((Line)draw2[0]).Draw();  // Type casting to Line type, Calling Base Line.Draw()
            ((Square)draw2[1]).Draw();  // Type casting to  Square type, Calling Base Square.Draw()
            Console.WriteLine();

            Circle circle = new Circle();
            circle.Draw(); // Calling Circle.Draw()
            Square square1 = new Circle();
            square1.Draw(); // Calling Square.Draw()
        }
    }
}
