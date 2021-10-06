using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IArea1
    {
        void Area();
    }
    interface IArea2
    {
        void Area();
    }
    class Polygon1
    {
        public int Len { get; set; }
        public int Wid { get; set; }
        public Polygon1() { }
        public Polygon1(int Len, int Wid)
        {
            this.Len = Len;
            this.Wid = Wid;
        }
    }
    class Cylinder1 : Polygon1, IArea1, IArea2
    {
        public Cylinder1() { }
        public Cylinder1(int Len, int Wid) : base(Len, Wid) { }
        void IArea1.Area()
        {
            Console.WriteLine($"This is IArea1 : {Len * Wid}");
        }
        void IArea2.Area()
        {
            Console.WriteLine($"This is IArea2 : {Len * Wid}");
        }
        public void Area()
        {
            Console.WriteLine($"This is Cylinder1 : {Len * Wid}");
        }
    }
}
