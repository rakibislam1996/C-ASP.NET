using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQMethodSyntaxLamba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };

            var studentList = students.Where((student,index) => student.Age>12 && student.Age<20);
            List<Student> studentList2 = students.Where(student => student.Age>12 && student.Age<20).ToList<Student>();
            foreach (var item in studentList)
                Console.Write(item.StudentName+" ");
            Console.WriteLine();
            
            Student student = students.Where(s => s.StudentName == "Chris").FirstOrDefault();
            Console.WriteLine(student.StudentName);
            
            
        }
    }
}
