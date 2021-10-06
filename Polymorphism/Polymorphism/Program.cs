using System;

namespace Polymorphism
{
    class Drawing
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is for draw");
        }
    }
    class Line : Drawing
    {
        public override void Draw()
        {
            Console.WriteLine("This is a line");
        }
    }
    class Circle : Line
    {
        public override void Draw()
        {
            Console.WriteLine("This is a circle");
        }
    }
    class Square : Drawing
    {
        public override void Draw()
        {
            Console.WriteLine("This is a square");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Drawing[] dObj = new Drawing[4];

            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new Drawing();

            foreach (var item in dObj)
            {
                item.Draw();
            }


        }
    }
}
