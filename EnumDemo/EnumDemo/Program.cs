using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumDemo
{
    enum WeekDays
    {
        Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> lst = new List<int> { 3, 6, 2, 3, 4 };

            var str = string.Join(',', lst);
            Console.WriteLine(str);

            string ss = "1,2,3,4,5,6";

            string[] s = ss.Split(',');


            IList<int> arr = ss.Split(',').Select(x => int.Parse(x)).ToList(); 
            
            Console.WriteLine(WeekDays.Sunday);
            string x = WeekDays.Sunday.ToString();
            Console.WriteLine(x);
            int y = ((int)WeekDays.Monday);
             x = y.ToString();
            Console.WriteLine((int)WeekDays.Monday);
            WeekDays wd = WeekDays.Sunday;
            Console.WriteLine(wd);
            wd = WeekDays.Monday;
            Console.WriteLine(wd);

            

        }
    }
}
