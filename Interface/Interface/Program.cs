using System;

namespace Interface
{
    interface IArea
    {
        void Length();
        void Area();
        void Volume();
    }
    interface IVolume
    {
        void Volume();
    }
    class Polygon
    {
        public int Len { get; set; }
        public int Wid { get; set; }
        public int Hei { get; set; }
        public Polygon() { }
        public Polygon(int Len, int Wid, int Hei)
        {
            this.Len = Len;
            this.Wid = Wid;
            this.Hei = Hei;
        }
    }
    class Cylinder : Polygon, IArea, IVolume
    {
        public Cylinder() { }
        public Cylinder(int Len, int Wid, int Hei) : base(Len,Wid,Hei){}
        public void Length()
        {
            Console.WriteLine($"The length is: {Len}");
        }
        public void Area()
        {
            Console.WriteLine(Len*Wid);
        }
        public void Volume()
        {
            Console.WriteLine(Len * Wid * Hei);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cyl = new Cylinder(10, 11, 12);
            cyl.Length();
            cyl.Area();
            cyl.Volume();

            IArea iarea = new Cylinder(2, 3, 4);
            iarea.Length();
            iarea.Area();
            iarea.Volume();

            IVolume ivol = new Cylinder(5, 6, 7);
            ivol.Volume();

            Cylinder1 cyl1 = new Cylinder1(10, 11);
            cyl1.Area();  // Calls own method
            ((IArea1)cyl1).Area();
            ((IArea2)cyl1).Area();

            IArea1 iarea1 = new Cylinder1(5,6);
            iarea1.Area();

            IArea2 iarea2 = new Cylinder1(3,2);
            iarea2.Area();

        }
    }
}
