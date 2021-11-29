using System;

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
            Console.WriteLine(WeekDays.Sunday);
            Console.WriteLine((int)WeekDays.Sunday);
            WeekDays wd = WeekDays.Sunday;
            Console.WriteLine(wd);
            wd = WeekDays.Monday;
            Console.WriteLine(wd);

        }
    }
}
