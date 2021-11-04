using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.WardNo = 11;
            address.Upozilla = "Sadar";
            address.District = "Cumilla";

            Student stu = new Student();
            stu.Id = 101;
            stu.Name = "Rakib";
            stu.stuAddress = address;

            Console.WriteLine($"Ward No = {stu.stuAddress.WardNo}");
            Console.WriteLine($"Upozilla = {stu.stuAddress.Upozilla}");
            Console.WriteLine($"District = {stu.stuAddress.District}");

            List<Student> student = new List<Student>() {
                stu,
                new Student(102, "Sakib"),
                new Student(103, "Fahim")
            };

            Department dept = new Department();
            dept.DeptName = "CSE";
            dept.students = student;

            foreach (var item in dept.students)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

        }
    }
}
