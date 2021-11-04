using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrLst = new ArrayList();
            arrLst.Add(12);
            arrLst.Add("Rakib");
            arrLst.Add('C');
            arrLst.Add(12.45);

            Console.WriteLine(arrLst[1]);

            foreach (var item in arrLst)
            {
                Console.WriteLine(item);
            }

        }
    }
}
