using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingVsHiding
{
    class Drawing1
    {
        public int len;
        public virtual void Draw()  // Virtual for hiding it for derived class's method
        {
            Console.WriteLine("This is for draw1");
        }
    }
    class Line1 : Drawing1
    {
        public int len;
        public override void Draw() // override for showing this method over base classe's method
        {
            Console.WriteLine("This is a line1");
        }
    }
    class Circle1 : Line1
    {
        public int len;
        public override void Draw()
        {
            Console.WriteLine("This is a circle1");
        }
    }
    //class Square1 : Drawing1
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("This is a square1");
    //    }
    //}
    
}
