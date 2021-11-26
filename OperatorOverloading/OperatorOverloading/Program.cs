using System;

namespace OperatorOverloading
{
    class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        int Area { get; set; }

        public int area
        {
            set { this.Area = value;  }
            get { return this.Area; }
        }

        public static Box operator + (Box obj1, Box obj2)
        {
            Box box = new Box();
            box.Length = obj1.Length + obj2.Length;
            box.Width = obj1.Width + obj2.Width;
            box.Height = obj1.Height + obj2.Height;
            return box;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.Length = 10;
            box1.Width = 5;
            box1.Height = 12;

            box1.area = 10;

            Box box2 = new Box();
            box2.Length = 35;
            box2.Width = 20;
            box2.Height = 25;

            Box box3 = box1 + box2;

            Console.WriteLine(box3.Length + " " + box3.Width + " " + box3.Height);
        }
    }
}
